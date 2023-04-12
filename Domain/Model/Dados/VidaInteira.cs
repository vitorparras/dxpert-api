namespace Domain.Model.Dados
{
    public class VidaInteira : BaseEntity
    {
        public int Idade { get; set; }
        public string? Homem { get; set; }
        public string? Mulher { get; set; }
    }
}
