using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoAgendamento
    {
        public long CoAgendamento { get; set; }
        public DateTime? DtHrInicio { get; set; }
        public DateTime? DtHrFim { get; set; }
        public long CoStatusAgendamento { get; set; }
        public long CoDiaryReportConsultor { get; set; }
        public long CoComplemento { get; set; }
    }
}
