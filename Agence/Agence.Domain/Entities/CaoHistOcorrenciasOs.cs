﻿using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoHistOcorrenciasOs
    {
        public int Idocorrencia { get; set; }
        public int? CoOs { get; set; }
        public string CoUsuario { get; set; }
        public DateTime? Data { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Responsavel { get; set; }
        public DateTime? DataFechamento { get; set; }

        public CaoOs CoOsNavigation { get; set; }
        public CaoUsuario CoUsuarioNavigation { get; set; }
    }
}
