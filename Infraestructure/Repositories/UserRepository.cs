
using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interface;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly string _secretKey;

        public UserRepository(AppDbContext context, IConfiguration configuration, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _secretKey = configuration["ApiSettings:Secret"];
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<User> GetByEmail(string email)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());
                if(user == null) { throw new NotFoundException("El Usuario con el email: " + email + " no fue encontrado."); }
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<LoginResponse> Login(User user, string password)
        {
            try
            {
                if (!await _userManager.CheckPasswordAsync(user, password)) //comprueba el password
                {
                    throw new BadRequestException("Password inválido.");
                }

                // si existe el user generamos el JWT
                var roles = await _userManager.GetRolesAsync(user);
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_secretKey);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, roles.FirstOrDefault())
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                LoginResponse response = new()
                {
                    Token = tokenHandler.WriteToken(token),
                    Role = roles.FirstOrDefault()
                };
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserResponse> Register(RegisterRequest request)
        {
            var userExists = await _context.Users.FirstOrDefaultAsync(u => u.Email.ToLower() == request.Email.ToLower());
            if (userExists != null) { throw new ConflictException("El email: " + request.Email + " ya se encuentra en uso."); }

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    User user = new()
                    {
                        UserName = request.Email,
                        Email = request.Email,
                        NormalizedEmail = request.Email.ToUpper(),
                    };
                    {

                    }
                    var result = await _userManager.CreateAsync(user, request.Password);
                    if (result.Succeeded)
                    {
                        await ValidationRole(request);
                        var role = await _roleManager.FindByIdAsync(request.Rol);
                        await _userManager.AddToRoleAsync(user, role.Name);
                        var userApp = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);

                        await transaction.CommitAsync();
                        return new UserResponse();
                    }
                    else
                    {
                        await ValidationPasswordException(result.Errors);
                        await transaction.CommitAsync();
                        return new UserResponse();
                    }
                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            } 
        }


        private async Task ValidationRole(RegisterRequest request)
        {
            //if (!_roleManager.RoleExistsAsync("admin").GetAwaiter().GetResult())
            //{
            //    await _roleManager.CreateAsync(new IdentityRole("admin"));
            //}
            //if (!_roleManager.RoleExistsAsync("company").GetAwaiter().GetResult())
            //{
            //    await _roleManager.CreateAsync(new IdentityRole("company"));
            //}
            //if (!_roleManager.RoleExistsAsync("jobuser").GetAwaiter().GetResult())
            //{
            //    await _roleManager.CreateAsync(new IdentityRole("jobuser"));
            //}

            //if (!_roleManager.RoleExistsAsync(request.Rol).GetAwaiter().GetResult())
            //{
            //    throw new BadRequestException("El tipo de Rol: " + request.Rol + " no existe.");
            //}
            //if (request.Rol.ToUpper() == "ADMIN")
            //{
            //    throw new UnauthorizedException("No tiene los permisos para crear un usuario de tipo " + request.Rol.ToUpper());
            //}
            var role = await _roleManager.FindByIdAsync(request.Rol);

            if (role == null)
            {
                throw new BadRequestException("Ingrese correctamente el ID del Rol.");
            }
            if (role.Id.ToLower() == "2048b194-4cda-4320-8b72-c169b4788fe9".ToLower())
            {
                throw new UnauthorizedException("No tiene los permisos para crear un usuario de tipo ADMIN");
            }
        }

        private async Task ValidationPasswordException(IEnumerable<IdentityError> errors)
        {
            try
            {
                foreach (var error in errors)
                {
                    if (error.Code == "PasswordRequiresNonAlphanumeric")
                    {
                        throw new BadRequestException("El password requiere al menos un carácter no alfanumérico.");
                    }
                    else if (error.Code == "PasswordRequiresDigit")
                    {
                        throw new BadRequestException("El password requiere al menos un dígito.");
                    }
                    else if (error.Code == "PasswordRequiresUpper")
                    {
                        throw new BadRequestException("El password requiere al menos una letra mayúscula.");
                    }
                    else if (error.Code == "DuplicateUserName")
                    {
                        throw new ConflictException("Existe un usuario con el mismo email, por favor, detalle otro.");
                    }
                    else
                    {
                        throw new InternalServerErrorException(error.ToString());
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
