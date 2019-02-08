using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoStatusClienteComplemento
    {
        public long CoComplementoStatus { get; set; }
        public string DsStatus { get; set; }
        public long? CoStatus { get; set; }
    }
}
