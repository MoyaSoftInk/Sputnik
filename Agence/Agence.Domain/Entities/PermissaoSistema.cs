﻿namespace Agence.Domain.Entities
{
    using System;

    public partial class PermissaoSistema
    {
        public string CoUsuario { get; set; }
        public decimal CoTipoUsuario { get; set; }
        public decimal CoSistema { get; set; }
        public string InAtivo { get; set; }
        public string CoUsuarioAtualizacao { get; set; }
        public DateTime? DtAtualizacao { get; set; }
    }
}
