using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoPontosConhecimento
    {
        public int Idpontos { get; set; }
        public int Pontuacao { get; set; }
        public string CoCoordenador { get; set; }
        public int Idconhecimento { get; set; }

        public virtual CaoUsuario CoCoordenadorNavigation { get; set; }
        public virtual CaoConhecimentos IdconhecimentoNavigation { get; set; }
        public virtual CaoEscalaRanking PontuacaoNavigation { get; set; }
    }
}
