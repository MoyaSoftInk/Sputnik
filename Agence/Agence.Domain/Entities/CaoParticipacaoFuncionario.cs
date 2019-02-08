using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoParticipacaoFuncionario
    {
        public long CoPartFuncionario { get; set; }
        public float PcParticipacao { get; set; }
        public string CoUsuario { get; set; }
        public byte CoEscritorio { get; set; }
        public DateTime? DtReferencia { get; set; }
    }
}
