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

        public CaoUsuario CoCoordenadorNavigation { get; set; }
        public CaoConhecimentos IdconhecimentoNavigation { get; set; }
        public CaoEscalaRanking PontuacaoNavigation { get; set; }
    }
}
