﻿using Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class Usuario : BaseEntity
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }

        public bool Ativo { get; set; } = true;

        public TipoUsuario Permissao { get; set; } = TipoUsuario.Normal;

        [Required]
        public string? Senha { get; set; }
    }
}
