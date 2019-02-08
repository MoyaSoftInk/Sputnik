using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
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
