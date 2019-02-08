using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoPagamento
    {
        public decimal CoPagamento { get; set; }
        public string CoUsuario { get; set; }
        public string TpPagamento { get; set; }
        public DateTime DtPagamento { get; set; }
        public float VlPagamento { get; set; }
        public DateTime? DtReferenciaPagamento { get; set; }
    }
}
