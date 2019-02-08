using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoValorDescanso
    {
        public int Id { get; set; }
        public string CoUsuario { get; set; }
        public string Segundos { get; set; }
        public string MesReferencia { get; set; }
    }
}
