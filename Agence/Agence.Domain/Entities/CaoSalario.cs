﻿using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoSalario
    {
        public string CoUsuario { get; set; }
        public DateTime DtAlteracao { get; set; }
        public float BrutSalario { get; set; }
        public float LiqSalario { get; set; }
    }
}
