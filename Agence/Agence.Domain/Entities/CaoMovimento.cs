using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoMovimento
    {
        public decimal CoMovimento { get; set; }
        public string CoUsuario { get; set; }
        public DateTime? DtEntrada { get; set; }
        public DateTime? DtSaidaAlmoco { get; set; }
        public DateTime? DtVoltaAlmoco { get; set; }
        public DateTime? DtSaida { get; set; }
        public byte IsEncerrado { get; set; }
    }
}
