using FundooApp.BusinessLayer.Interfaces;
using FundooApp.ModelLayer.DTOs;
using FundooApp.ModelLayer.Entities;
using FundooApp.ModelLayer.Helpers;
using FundooApp.RepositoryLayer.Interfaces;

namespace FundooApp.BusinessLayer.Services
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtService _jwtService;

        public UserBusiness(
            IUserRepository userRepository,
            IJwtService jwtService)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
        }

        // ================= REGISTER =================

        public async Task<ResponseDTO> Register(
            RegistrationDTO registrationDTO)
        {
            var existingUser =
                await _userRepository.GetUserByEmail(
                    registrationDTO.Email);

            if (existingUser != null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Message = "Email already registered"
                };
            }

            var passwordResult =
                PasswordHasher.HashPassword(
                    registrationDTO.Password);

            User user = new User
            {
                FirstName = registrationDTO.FirstName,
                LastName = registrationDTO.LastName,
                Email = registrationDTO.Email,
                PasswordHash = passwordResult.Hash,
                PasswordSalt = passwordResult.Salt
            };

            await _userRepository.RegisterUser(user);

            return new ResponseDTO
            {
                Success = true,
                Message = "User registered successfully"
            };
        }

        // ================= LOGIN =================

        public async Task<ResponseDTO> Login(
            LoginDTO loginDTO)
        {
            var user =
                await _userRepository.LoginUser(
                    loginDTO.Email);

            if (user == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Message = "Invalid email or password"
                };
            }

            bool isPasswordValid =
                PasswordHasher.VerifyPassword(
                    loginDTO.Password,
                    user.PasswordHash,
                    user.PasswordSalt);

            if (!isPasswordValid)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Message = "Invalid email or password"
                };
            }

            // Generate JWT token
            string token =
                _jwtService.GenerateToken(
                    user.UserId,
                    user.Email);

            return new ResponseDTO
            {
                Success = true,
                Message = "Login successful",
                Token = token
            };
        }

        // ================= FORGOT PASSWORD =================

        public async Task<ResponseDTO> ForgotPassword(
            string email)
        {
            var user =
                await _userRepository.GetUserByEmail(email);

            if (user == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Message = "Email not registered"
                };
            }

            return new ResponseDTO
            {
                Success = true,
                Message = "Password recovery request accepted"
            };
        }
    }
}