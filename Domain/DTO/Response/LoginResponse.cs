namespace Domain.DTO.Response
{
    public class LoginResponse: ResponseBase
    {
        public string? Token { get; set; }
        public int IdUser { get; set; }
        public string? Nome { get; set; }

        
    }

}
