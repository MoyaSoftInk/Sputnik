using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoTipoOmbudsman
    {
        public CaoTipoOmbudsman()
        {
            CaoOmbudsman = new HashSet<CaoOmbudsman>();
        }

        public short Idtipo { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<CaoOmbudsman> CaoOmbudsman { get; set; }
    }
}
