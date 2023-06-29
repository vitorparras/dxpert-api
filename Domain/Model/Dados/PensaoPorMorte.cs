﻿namespace Domain.Model.Dados
{
    public class PensaoPorMorte : BaseEntity
    {
        public int Idade { get; set; }
        public double I10 { get; set; }
        public double I15 { get; set; }
        public double I20 { get; set; }


        public static string GetQueryInsertBase() => $@" INSERT INTO PensaoPorMorte (Idade, I10, I15,I20) VALUES
                ('16',  '24.62',  '34.83',  '43.85'),
                ('17',  '24.62',  '34.83',  '43.85'),
                ('18',  '24.62',  '34.83',  '43.85'),
                ('19',  '24.62',  '34.83',  '43.85'),
                ('20',  '24.62',  '34.83',  '43.85'),
                ('21',  '24.62',  '34.83',  '43.85'),
                ('22',  '24.62',  '34.83',  '43.85'),
                ('23',  '24.62',  '34.83',  '43.85'),
                ('24',  '24.62',  '34.83',  '43.85'),
                ('25',  '24.62',  '34.83',  '43.85'),
                ('26',  '24.62',  '34.83',  '43.85'),
                ('27',  '24.62',  '34.83',  '43.85'),
                ('28',  '24.62',  '34.83',  '43.85'),
                ('29',  '24.62',  '34.83',  '43.85'),
                ('30',  '24.62',  '34.83',  '43.85'),
                ('31',  '29.35',  '41.52',  '52.28'),
                ('32',  '29.35',  '41.52',  '52.28'),
                ('33',  '29.35',  '41.52',  '52.28'),
                ('34',  '29.35',  '41.52',  '52.28'),
                ('35',  '29.35',  '41.52',  '52.28'),
                ('36',  '35.89',  '50.77',  '63.92'),
                ('37',  '35.89',  '50.77',  '63.92'),
                ('38',  '35.89',  '50.77',  '63.92'),
                ('39',  '35.89',  '50.77',  '63.92'),
                ('40',  '35.89',  '50.77',  '63.92'),
                ('41',  '53.83',  '76.16',  '95.89'),
                ('42',  '53.83',  '76.16',  '95.89'),
                ('43',  '53.83',  '76.16',  '95.89'),
                ('44',  '53.83',  '76.16',  '95.89'),
                ('45',  '53.83',  '76.16',  '95.89'),
                ('46',  '79.84',  '112.95',  '142.22'),
                ('47',  '79.84',  '112.95',  '142.22'),
                ('48',  '79.84',  '112.95',  '142.22'),
                ('49',  '79.84',  '112.95',  '142.22'),
                ('50',  '79.84',  '112.95',  '142.22'),
                ('51',  '121.16',  '171.4',  '215.81'),
                ('52',  '121.16',  '171.4',  '215.81'),
                ('53',  '121.16',  '171.4',  '215.81'),
                ('54',  '121.16',  '171.4',  '215.81'),
                ('55',  '121.16',  '171.4',  '215.81'),
                ('56',  '189.04',  '267.43',  '336.72'),
                ('57',  '189.04',  '267.43',  '336.72'),
                ('58',  '189.04',  '267.43',  '336.72'),
                ('59',  '189.04',  '267.43',  '336.72'),
                ('60',  '189.04',  '267.43',  '336.72'),
                ('61',  '243.98',  '345.16',  '434.58'),
                ('62',  '266.94',  '377.63',  '475.46'),
                ('63',  '292.95',  '414.43',  '521.8'),
                ('64',  '321.88',  '455.36',  '573.33'),
                ('65',  '353.6',  '500.22',  '629.82'),
                ('66',  '387.4',  '548.04',  '690.03'),
                ('67',  '423.42',  '599.01',  '754.2'),
                ('68',  '461.68',  '653.13',  '822.34'),
                ('69',  '503.13',  '711.77',  '896.17'),
                ('70',  '549.59',  '777.49',  '978.93'),
                ('71',  '602.31',  '852.07',  '1072.73'),
                ('72',  '662.82',  '937.68',  '1180.61'),
                ('73',  '732.23',  '1035.87',  '1304.25'),
                ('74',  '809.43',  '1145.09',  '1441.76'),
                ('75',  '892.89',  '1263.16',  '1590.42'),
                ('76',  '981.08',  '1387.92',  '1747.5'),
                ('77',  '1072.75',  '1517.6',  '1910.78'),
                ('78',  '1167.06',  '1651.02',  '2078.77'),
                ('79',  '1266.52',  '1791.72',  '2255.92'),
                ('80',  '1374.88',  '1945.01',  '2448.93');";


    }
}
