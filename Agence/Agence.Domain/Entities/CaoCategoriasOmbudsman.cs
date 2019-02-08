using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoCategoriasOmbudsman
    {
        public CaoCategoriasOmbudsman()
        {
            CaoOmbudsman = new HashSet<CaoOmbudsman>();
        }

        public short Idcategoria { get; set; }
        public string Descricao { get; set; }

        public ICollection<CaoOmbudsman> CaoOmbudsman { get; set; }
    }
}
