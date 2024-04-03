using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interface
{
    public interface IUserService
    {
        Task<LoginResponse> Login(LoginRequest request);
        Task<UserResponse> Register(RegisterRequest request);
    }
}
