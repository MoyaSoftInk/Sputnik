using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoFormacaoUsuario
    {
        public string CoUsuario { get; set; }
        public string TpCurso { get; set; }
        public string DsCurso { get; set; }
        public string DsInstituicao { get; set; }
        public DateTime? DtConclusao { get; set; }
    }
}
