namespace Domain.Model.Dados
{
    public class VidaInteiraConjuge : BaseEntity
    {
        public int Idade { get; set; }
        public string? Homem { get; set; }
        public string? Mulher { get; set; }
    }
}
