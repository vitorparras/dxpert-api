namespace Domain.Model.Dados
{
    public class DoencasGraves : BaseEntity
    {
        public int Idade { get; set; }
        public double Essencial { get; set; }
        public double Plus { get; set; }
        public double Premium { get; set; }
    }
}
