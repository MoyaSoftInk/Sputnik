using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoMenuContador
    {
        public string CoUsuario { get; set; }
        public byte CoMenu { get; set; }
        public short NuPontos { get; set; }
        public byte InProcessado { get; set; }
    }
}
