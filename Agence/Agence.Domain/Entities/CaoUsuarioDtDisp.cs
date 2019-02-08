using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoUsuarioDtDisp
    {
        public long CoDtDisp { get; set; }
        public string CoUsuario { get; set; }
        public DateTime DtDisp { get; set; }
        public DateTime DtAlt { get; set; }
    }
}
