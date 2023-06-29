namespace Domain.Model.Dados
{
    public class InvalidezTotalAcidente : BaseEntity
    {
        public int Idade { get; set; }
        public double Valor { get; set; }


        public static string GetQueryInsertBase() => $@"  INSERT INTO InvalidezTotalAcidente(Idade, Valor) VALUES
                ('61',  '0.07'),
                ('62',  '0.07'),
                ('63',  '0.07'),
                ('64',  '0.07'),
                ('65',  '0.07'),
                ('66',  '0.07'),
                ('67',  '0.07'),
                ('68',  '0.07'),
                ('69',  '0.07'),
                ('70',  '0.07'),
                ('71',  '0.07'),
                ('72',  '0.07'),
                ('73',  '0.07'),
                ('74',  '0.07'),
                ('75',  '0.07'),
                ('76',  '0.07'),
                ('77',  '0.07'),
                ('78',  '0.07'),
                ('79',  '0.07'),
                ('80',  '0.07');";
    }
}
