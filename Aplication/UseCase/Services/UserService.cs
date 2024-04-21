using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interface;
using System.Text.RegularExpressions;

namespace Application.UseCase.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            try
            {
                IsValidEmail(request.Email);
                var user = await _userRepository.GetByEmail(request.Email);

                return await _userRepository.Login(user, request.Password);
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
                IsValidEmail(request.Email);
                return await _userRepository.Register(request);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void IsValidEmail(string email)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if (!Regex.IsMatch(email, pattern))
            {
                throw new BadRequestException("Ingrese un Email válido.");
            }
        }
    }
}
