using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace UserAuthMS.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private HTTPResponse<Object> _response;

        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
            _response = new();
        }

        [HttpPost("login")]
        [ProducesResponseType(typeof(HTTPResponse<LoginResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var loginResponse = await _userRepository.Login(request);
            if (loginResponse.User == null && string.IsNullOrEmpty(loginResponse.Token))
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Status = "BadRequest";
                _response.Message.Add("UserName o Password incorrectos.");
                return BadRequest(_response);
            }
            _response.StatusCode = HttpStatusCode.OK;
            _response.Status = "Created";
            _response.Result = loginResponse;
            return Ok(_response);
        }

        [HttpPost("register")]
        [ProducesResponseType(typeof(HTTPResponse<UserResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            bool isUniqueUser = _userRepository.IsUniqueUser(request.UserName);

            if (!isUniqueUser)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Status = "BadRequest";
                _response.Message.Add("El usuario ya existe.");
                return BadRequest(_response);
            }
            var user = await _userRepository.Register(request);
            if (user == null)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Status = "BadRequest";
                _response.Message.Add("Error al registrar el usuario.");
                return BadRequest(_response);
            }
            _response.StatusCode = HttpStatusCode.OK;
            _response.Status = "OK";
            _response.Result = user;
            return Ok(_response);
        }
    }
}
