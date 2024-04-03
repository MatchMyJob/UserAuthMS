
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

        public async Task<User> GetByUserName(string userName)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName.ToLower() == userName.ToLower());
                if(user == null) { throw new NotFoundException("El Usuario " + userName + " no fue encontrado."); }
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
                    new Claim(ClaimTypes.Name, user.UserName.ToString()),
                    new Claim(ClaimTypes.Role, roles.FirstOrDefault())
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                LoginResponse response = new()
                {
                    User = new UserResponse()
                    {
                        Id = user.Id,
                        UserName = user.UserName
                    },
                    Token = tokenHandler.WriteToken(token)
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
            try
            {
                User user = new()
                {
                    UserName = request.UserName,
                    Email = request.Email,
                    NormalizedEmail = request.Email.ToUpper(),
                };

                var result = await _userManager.CreateAsync(user, request.Password);
                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("admin").GetAwaiter().GetResult())
                    {
                        await _roleManager.CreateAsync(new IdentityRole("admin"));
                    }
                    await _userManager.AddToRoleAsync(user, "admin");
                    var userApp = await _context.Users.FirstOrDefaultAsync(u => u.UserName == request.UserName);
                    return new UserResponse()
                    {
                        Id = userApp.Id,
                        UserName = userApp.UserName
                    };
                }
                else
                {
                    await ValidationPasswordException(result.Errors);
                    return new UserResponse();
                }
            }
            catch (Exception)
            {
                throw;
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
                        throw new ConflictException("Existe un usuario con el mismo UserName, por favor, detalle otro.");
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
