using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoHelpFilial
    {
        public long CoFilial { get; set; }
        public string NoFilial { get; set; }
        public int CoCliente { get; set; }
        public string Estado { get; set; }
    }
}
