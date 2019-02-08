using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoBancoHoras
    {
        public long CoBancHoras { get; set; }
        public string CoUsuario { get; set; }
        public string Periodo { get; set; }
        public int MinMes { get; set; }
        public int MinFerias { get; set; }
        public int MinPago { get; set; }
        public int MinTotal { get; set; }
    }
}
