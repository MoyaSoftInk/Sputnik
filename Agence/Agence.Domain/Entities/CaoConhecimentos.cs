using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoConhecimentos
    {
        public CaoConhecimentos()
        {
            CaoConhecimentosFontes = new HashSet<CaoConhecimentosFontes>();
            CaoPontosConhecimento = new HashSet<CaoPontosConhecimento>();
        }

        public int Idconhecimento { get; set; }
        public string Assunto { get; set; }
        public string Conhecimento { get; set; }
        public string Url { get; set; }
        public string Tags { get; set; }
        public string Usuario { get; set; }
        public DateTime? Datahora { get; set; }

        public CaoUsuario UsuarioNavigation { get; set; }
        public ICollection<CaoConhecimentosFontes> CaoConhecimentosFontes { get; set; }
        public ICollection<CaoPontosConhecimento> CaoPontosConhecimento { get; set; }
    }
}
