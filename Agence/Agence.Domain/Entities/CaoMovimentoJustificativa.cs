using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoMovimentoJustificativa
    {
        public decimal CoMovimentoJustificativa { get; set; }
        public decimal CoMovimento { get; set; }
        public decimal NuOs { get; set; }
        public string DsJustificativa { get; set; }
    }
}
