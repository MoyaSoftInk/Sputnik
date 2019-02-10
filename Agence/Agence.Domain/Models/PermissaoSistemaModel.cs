namespace Agence.Domain.Models
{
    using System;

    public class PermissaoSistemaModel
    {
        public PermissaoSistemaModel()
        {

        }
        public string CoUsuario { get; set; }
        public decimal CoTipoUsuario { get; set; }
        public decimal CoSistema { get; set; }
        public string InAtivo { get; set; }
        public string CoUsuarioAtualizacao { get; set; }
        public DateTime? DtAtualizacao { get; set; }
    }
}
