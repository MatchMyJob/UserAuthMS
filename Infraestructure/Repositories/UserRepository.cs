
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interface;
using Domain.Entities;
using Infraestructure.Persistence;
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
        private readonly string _secretKey;

        public UserRepository(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _secretKey = configuration["ApiSettings:Secret"];
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
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName.ToLower() == request.UserName.ToLower() &&
                                                                     u.Password == request.Password);
            if(user == null)
            {
                return new LoginResponse() 
                {
                    Token = "",
                    User = null
                };
            }
            // si existe el user generamos el JWT
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Rol)
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            LoginResponse response = new()
            {
                Token = tokenHandler.WriteToken(token),
                User = user
            };
            return response;
        }

        public async Task<User> Register(RegisterRequest request)
        {
            User user = new()
            {
                UserName = request.UserName,
                Name = request.Name,
                Password = request.Password,
                Rol = request.Rol
            };
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            user.Password = "";
            return user;
        }
    }
}
