namespace Domain.Model.Dados
{
    public class DoencasGravesMaster : BaseEntity
    {
        public int Idade { get; set; }
        public double Valor { get; set; }

        public static string GetQueryInsertBase() => $@"INSERT INTO DoencasGravesMaster (Idade, Valor) VALUES
            ('66',  '3.53'),
            ('67',  '3.69'),
            ('68',  '3.85'),
            ('69',  '4.06'),
            ('70',  '4.27'),
            ('71',  '4.47'),
            ('72',  '4.68'),
            ('73',  '4.88'),
            ('74',  '5.2'),
            ('75',  '5.53'),
            ('76',  '5.85'),
            ('77',  '5.89'),
            ('78',  '6.49'),
            ('79',  '7.16'),
            ('80',  '7.89'),
            ('81',  '8.68'),
            ('82',  '9.55'),
            ('83',  '10.5'),
            ('84',  '11.51'),
            ('85',  '12.58');";
    }
}
