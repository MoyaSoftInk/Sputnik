using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoEscalaRanking
    {
        public CaoEscalaRanking()
        {
            CaoPontosConhecimento = new HashSet<CaoPontosConhecimento>();
        }

        public int Idescala { get; set; }
        public short QtdVisual { get; set; }
        public int Pontuacao { get; set; }

        public virtual ICollection<CaoPontosConhecimento> CaoPontosConhecimento { get; set; }
    }
}
