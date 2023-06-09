﻿namespace Domain.Model.Dados
{
    public class PrazoCerto : BaseEntity
    {
        public int Idade { get; set; }
        public double I5 { get; set; }
        public double I10 { get; set; }
        public double I15 { get; set; }
        public double I20 { get; set; }

        public static string GetQueryInsertBase() => $@" INSERT INTO PrazoCerto(Idade, I5, I10, I15, I20) VALUES
                ('16',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('17',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('18',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('19',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('20',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('21',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('22',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('23',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('24',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('25',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('26',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('27',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('28',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('29',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('30',  '0.2',  '0.21',   '0.23',  '0.26'),
                ('31',  '0.25',  '0.3',    '0.36',  '0.43'),
                ('32',  '0.25',  '0.3',    '0.36',  '0.43'),
                ('33',  '0.25',  '0.3',    '0.36',  '0.43'),
                ('34',  '0.25',  '0.3',    '0.36',  '0.43'),
                ('35',  '0.25',  '0.3',    '0.36',  '0.43'),
                ('36',  '0.35',  '0.43',   '0.53',  '0.65'),
                ('37',  '0.35',  '0.43',   '0.53',  '0.65'),
                ('38',  '0.35',  '0.43',   '0.53',  '0.65'),
                ('39',  '0.35',  '0.43',   '0.53',  '0.65'),
                ('40',  '0.35',  '0.43',   '0.53',  '0.65'),
                ('41',  '0.53',  '0.65',   '0.8',  '0.98'),
                ('42',  '0.53',  '0.65',   '0.8',  '0.98'),
                ('43',  '0.53',  '0.65',   '0.8',  '0.98'),
                ('44',  '0.53',  '0.65',   '0.8',  '0.98'),
                ('45',  '0.53',  '0.65',   '0.8',  '0.98'),
                ('46',  '0.79',  '0.98',   '1.21',  '1.5'),
                ('47',  '0.79',  '0.98',   '1.21',  '1.5'),
                ('48',  '0.79',  '0.98',   '1.21',  '1.5'),
                ('49',  '0.79',  '0.98',   '1.21',  '1.5'),
                ('50',  '0.79',  '0.98',   '1.21',  '1.5'),
                ('51',  '1.23',  '1.52',   '1.88',  '0'),
                ('52',  '1.23',  '1.52',   '1.88',  '0'),
                ('53',  '1.23',  '1.52',   '1.88',  '0'),
                ('54',  '1.23',  '1.52',   '1.88',  '0'),
                ('55',  '1.23',  '1.52',   '1.88',  '0'),
                ('56',  '1.89',  '2.36',   '0',  '0'),
                ('57',  '1.89',  '2.36',   '0',  '0'),
                ('58',  '1.89',  '2.36',   '0',  '0'),
                ('59',  '1.89',  '2.36',   '0',  '0'),
                ('60',  '1.89',  '2.36',   '0',  '0');";
    }
}
