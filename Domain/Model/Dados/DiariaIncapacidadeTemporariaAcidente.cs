namespace Domain.Model.Dados
{
    public class DiariaIncapacidadeTemporariaAcidente : BaseEntity
    {
        public string? RendaMensal { get; set; }
        public string? MorteAcidental { get; set; }
        public string? InvalidezAcidentalMajorada { get; set; }
        public string? I13a30 { get; set; }
        public string? I31a35 { get; set; }
        public string? I36a40 { get; set; }
        public string? I41a45 { get; set; }
        public string? I46a50 { get; set; }
        public string? I51a55 { get; set; }
        public string? I56a60 { get; set; }
        public string? I61a65 { get; set; }
    }
}
