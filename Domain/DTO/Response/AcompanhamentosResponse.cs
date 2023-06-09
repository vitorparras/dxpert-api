﻿using Domain.Model;
using System.Collections.Generic;

namespace Domain.DTO.Response
{
    public class AcompanhamentosResponse 
    {
        public string? CadastroId { get; set; }
        public string? CadastroEmail { get; set; }
        public string? CadastroTelefone { get; set; }
        public string? CadastroEtapa { get; set; }
        public string? UserResponsavel { get; set; }
    }
}
