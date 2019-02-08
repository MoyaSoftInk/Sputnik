using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoDocumentacaoSistema
    {
        public int Id { get; set; }
        public int CoSistema { get; set; }
        public string Descricao { get; set; }
        public string Pasta { get; set; }
        public int? SubGrupo { get; set; }
        public string CoUsuario { get; set; }
        public DateTime? DtDoc { get; set; }
        public string Arquivo { get; set; }
    }
}
