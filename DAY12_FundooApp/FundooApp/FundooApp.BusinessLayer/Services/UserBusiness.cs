using FundooApp.BusinessLayer.Interfaces;
using FundooApp.ModelLayer.DTOs;
using FundooApp.ModelLayer.Entities;
using FundooApp.RepositoryLayer.Interfaces;

namespace FundooApp.BusinessLayer.Services
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _userRepository;

        public UserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ResponseDTO> Register(RegistrationDTO registrationDTO)
        {
            var existingUser =
                await _userRepository.GetUserByEmail(registrationDTO.Email);

            if (existingUser != null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Message = "Email already registered"
                };
            }

            User user = new User
            {
                FirstName = registrationDTO.FirstName,
                LastName = registrationDTO.LastName,
                Email = registrationDTO.Email,
                Password = registrationDTO.Password
            };

            await _userRepository.RegisterUser(user);

            return new ResponseDTO
            {
                Success = true,
                Message = "User registered successfully"
            };
        }

        public async Task<ResponseDTO> Login(LoginDTO loginDTO)
        {
            var user = await _userRepository.LoginUser(
                loginDTO.Email,
                loginDTO.Password);

            if (user == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Message = "Invalid email or password"
                };
            }

            return new ResponseDTO
            {
                Success = true,
                Message = "Login successful"
            };
        }

        public async Task<ResponseDTO> ForgotPassword(string email)
        {
            var user = await _userRepository.GetUserByEmail(email);

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