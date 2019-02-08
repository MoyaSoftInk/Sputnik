using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoComissao
    {
        public int CoComissao { get; set; }
        public int CoFatura { get; set; }
        public DateTime DtEfetuado { get; set; }
    }
}
