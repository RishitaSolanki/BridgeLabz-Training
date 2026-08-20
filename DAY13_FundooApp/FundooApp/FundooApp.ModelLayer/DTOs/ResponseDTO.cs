namespace FundooApp.ModelLayer.DTOs
{
    public class ResponseDTO
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public string? Token { get; set; }
    }
}