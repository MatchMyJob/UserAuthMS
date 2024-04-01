using Application.DTO.Request;
using Application.DTO.Response;
using Domain.Entities;

namespace Application.Interface
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string userName);

        Task<LoginResponse> Login(LoginRequest request);

        Task<UserResponse> Register(RegisterRequest request);
    }
}
