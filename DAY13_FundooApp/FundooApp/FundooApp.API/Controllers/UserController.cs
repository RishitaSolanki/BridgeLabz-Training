using FundooApp.BusinessLayer.Interfaces;
using FundooApp.ModelLayer.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

        // ================= REGISTER =================

        [HttpPost("register")]
        public async Task<IActionResult> Register(
            RegistrationDTO registrationDTO)
        {
            var response =
                await _userBusiness.Register(registrationDTO);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        // ================= LOGIN =================

        [HttpPost("login")]
        public async Task<IActionResult> Login(
            LoginDTO loginDTO)
        {
            var response =
                await _userBusiness.Login(loginDTO);

            if (!response.Success)
            {
                return Unauthorized(response);
            }

            return Ok(response);
        }

        // ================= FORGOT PASSWORD =================

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(
            [FromQuery] string email)
        {
            var response =
                await _userBusiness.ForgotPassword(email);

            if (!response.Success)
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        // ================= PROTECTED PROFILE =================

        [HttpGet("profile")]
        [Authorize]
        public IActionResult GetProfile()
        {
            var userId =
                User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var email =
                User.FindFirst(ClaimTypes.Email)?.Value;

            return Ok(new
            {
                success = true,
                message = "You are authorized",
                userId = userId,
                email = email
            });
        }
    }
}