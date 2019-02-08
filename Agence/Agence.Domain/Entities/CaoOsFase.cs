using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoOsFase
    {
        public int CoFase { get; set; }
        public string Descricao { get; set; }
        public string DescricaoIngl { get; set; }
        public int? Ordem { get; set; }
    }
}
