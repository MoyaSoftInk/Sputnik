using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoSistemaObs
    {
        public long CoObs { get; set; }
        public string Descricao { get; set; }
        public long? CoSistema { get; set; }
        public string CoUsuario { get; set; }
        public DateTime? DtObs { get; set; }
    }
}
