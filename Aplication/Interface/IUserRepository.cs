using Application.DTO.Request;
using Application.DTO.Response;
using Domain.Entities;

namespace Application.Interface
{
    public interface IUserRepository
    {
        Task<User> GetByEmail(string userName);

        Task<LoginResponse> Login(User user, string password);

        Task<UserResponse> Register(RegisterRequest request);
    }
}
