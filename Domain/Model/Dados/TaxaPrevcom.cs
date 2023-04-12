namespace Domain.Model.Dados
{
    public class TaxaPrevcom : BaseEntity
    {
        public int Idade { get; set; }
        public string? Morte { get; set; }
        public string? Invalidez { get; set; }
        public string? PercentualReajusteMorte { get; set; }
        public string? PercentualReajusteInvalidez { get; set; }
    }
}
