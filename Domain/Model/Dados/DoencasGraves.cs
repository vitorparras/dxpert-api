namespace Domain.Model.Dados
{
    public class DoencasGraves : BaseEntity
    {
        public int Idade { get; set; }
        public string? Essencial { get; set; }
        public string? Plus { get; set; }
        public string? Premium { get; set; }
    }
}
