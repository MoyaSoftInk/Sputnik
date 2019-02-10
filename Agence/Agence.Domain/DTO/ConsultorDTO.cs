namespace Agence.Domain.DTO
{
    using System.Collections.Generic;

    public class ConsultorDTO
    {
        public ConsultorDTO()
        {
            Consultors = new HashSet<Consultor>();
        }
        public ICollection<Consultor> Consultors { get; set; }
        
    }

    public class Consultor
    {
        public Consultor()
        {

        }

        public string CoUser { get; set; }
        public string NoUser { get; set; }

    }
}
