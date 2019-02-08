using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoConhecimentoUsuario
    {
        public string CoUsuario { get; set; }
        public long CoConhecimento { get; set; }
        public long? NvConhecimento { get; set; }
        public byte? IsCertificado { get; set; }
    }
}
