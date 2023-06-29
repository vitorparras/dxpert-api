﻿namespace Domain.Model.Dados
{
    public class AdicionalDiariaInternacaoHospitalar : BaseEntity
    {
        public int Idade { get; set; }
        public double Valor { get; set; }


        public static string GetQueryInsertBase() => $@"INSERT INTO AdicionalDiariaInternacaoHospitalar (Idade, Valor) VALUES
                ('16',    '0.12'), 
                ('17',    '0.12'), 
                ('18',    '0.12'), 
                ('19',    '0.12'), 
                ('20',    '0.19'), 
                ('21',    '0.19'), 
                ('22',    '0.19'), 
                ('23',    '0.19'), 
                ('24',    '0.19'), 
                ('25',    '0.19'), 
                ('26',    '0.19'), 
                ('27',    '0.19'), 
                ('28',    '0.19'), 
                ('29',    '0.19'), 
                ('30',    '0.17'), 
                ('31',    '0.17'), 
                ('32',    '0.17'), 
                ('33',    '0.17'), 
                ('34',    '0.17'), 
                ('35',    '0.17'), 
                ('36',    '0.17'), 
                ('37',    '0.17'), 
                ('38',    '0.17'), 
                ('39',    '0.17'), 
                ('40',    '0.29'), 
                ('41',    '0.29'), 
                ('42',    '0.29'), 
                ('43',    '0.29'), 
                ('44',    '0.29'), 
                ('45',    '0.29'), 
                ('46',    '0.29'), 
                ('47',    '0.29'), 
                ('48',    '0.29'), 
                ('49',    '0.29'), 
                ('50',    '0.56'), 
                ('51',    '0.56'), 
                ('52',    '0.56'), 
                ('53',    '0.56'), 
                ('54',    '0.56'), 
                ('55',    '0.56'), 
                ('56',    '0.56'), 
                ('57',    '0.56'), 
                ('58',    '0.56'), 
                ('59',    '0.56'), 
                ('60',    '1.09'), 
                ('61',    '1.09'), 
                ('62',    '1.09'), 
                ('63',    '1.09'), 
                ('64',    '1.09'), 
                ('65',    '1.09');";
    }
}
