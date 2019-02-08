using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoClienteContato
    {
        public long CoCliente { get; set; }
        public DateTime? DtContato { get; set; }
        public long? FgAgendado { get; set; }
        public TimeSpan? HrIni { get; set; }
        public TimeSpan? HrEnd { get; set; }
    }
}
