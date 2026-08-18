using FundooApp.BusinessLayer.Interfaces;
using FundooApp.ModelLayer.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FundooApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness _userBusiness;

        public UserController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        // POST: api/User/register
        [HttpPost("register")]
        public async Task<IActionResult> Register(
            RegistrationDTO registrationDTO)
        {
            var response = await _userBusiness.Register(registrationDTO);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        // POST: api/User/login
        [HttpPost("login")]
        public async Task<IActionResult> Login(
            LoginDTO loginDTO)
        {
            var response = await _userBusiness.Login(loginDTO);

            if (!response.Success)
            {
                return Unauthorized(response);
            }

            return Ok(response);
        }

        // POST: api/User/forgot-password
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(
            [FromQuery] string email)
        {
            var response = await _userBusiness.ForgotPassword(email);

            if (!response.Success)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}