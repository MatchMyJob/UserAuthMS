
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

        public bool IsUniqueUser(string userName)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserName.ToLower() == userName.ToLower());

            if(user == null)
            {
                return true;
            }
            return false;
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName.ToLower() == request.UserName.ToLower());

            bool isValid = await _userManager.CheckPasswordAsync(user, request.Password);
            
            if(user == null || !isValid)
            {
                return new LoginResponse() 
                {
                    Token = "",
                    User = null
                };
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

        public async Task<UserResponse> Register(RegisterRequest request)
        {
            User user = new()
            {
                UserName = request.UserName.ToUpper(),
                Email = request.Email,
                NormalizedEmail = request.Email.ToUpper(),
            };
            try
            {
                var result = await _userManager.CreateAsync(user, request.Password);
                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("admin").GetAwaiter().GetResult())
                    {
                        await _roleManager.CreateAsync(new IdentityRole("admin"));
                    }
                    await _userManager.AddToRoleAsync(user, "admin");
                    var userApp = _context.Users.FirstOrDefault(u => u.UserName == request.UserName);
                    return new UserResponse()
                    {
                        Id = userApp.Id,
                        UserName = userApp.UserName
                    };
                }
            }
            catch (Exception)
            {
                throw;
            }

            return new UserResponse();
        }
    }
}
