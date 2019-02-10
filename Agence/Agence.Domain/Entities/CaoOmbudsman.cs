using System;
using System.Collections.Generic;

namespace Agence.Domain.Entities
{
    public partial class CaoOmbudsman
    {
        public int Id { get; set; }
        public short Idtipo { get; set; }
        public short Idcategoria { get; set; }
        public DateTime? Data { get; set; }
        public string Comentario { get; set; }
        public short CoEscritorio { get; set; }

        public virtual CaoCategoriasOmbudsman IdcategoriaNavigation { get; set; }
        public virtual CaoTipoOmbudsman IdtipoNavigation { get; set; }
    }
}
