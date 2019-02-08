using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoDiaryReport
    {
        public int CoDiaryReport { get; set; }
        public TimeSpan? HrGasta { get; set; }
        public int CoAtividade { get; set; }
        public string DsAssunto { get; set; }
        public long CoMovimento { get; set; }
        public decimal? NuOs { get; set; }
        public decimal? CoSistema { get; set; }
    }
}
