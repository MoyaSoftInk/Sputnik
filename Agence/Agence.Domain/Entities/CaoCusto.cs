using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoCusto
    {
        public decimal CoCusto { get; set; }
        public short CoTipoCusto { get; set; }
        public string Descricao { get; set; }
        public short CoEscritorio { get; set; }
        public DateTime? DtCompra { get; set; }
        public DateTime? DtPagamento { get; set; }
        public string CoBoleto { get; set; }
        public float Valor { get; set; }
        public string Parcela { get; set; }
        public short? Pag { get; set; }
        public decimal CoCustoHigh { get; set; }
    }
}
