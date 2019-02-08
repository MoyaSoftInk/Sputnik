using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoOsPrazo
    {
        public int CoPrazo { get; set; }
        public int? CoOs { get; set; }
        public long? CoFase { get; set; }
        public int? TotalAnalista { get; set; }
        public int? TotalHora { get; set; }
    }
}
