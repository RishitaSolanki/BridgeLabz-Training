using FundooApp.ModelLayer.DTOs;

namespace FundooApp.BusinessLayer.Interfaces
{
    public interface IUserBusiness
    {
        Task<ResponseDTO> Register(RegistrationDTO registrationDTO);

        Task<ResponseDTO> Login(LoginDTO loginDTO);

        Task<ResponseDTO> ForgotPassword(string email);
    }
}