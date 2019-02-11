namespace Agence.Domain.Models
{
    using System;

    public class CaoSalarioModel
    {
        public CaoSalarioModel()
        {

        }

        public string CoUsuario { get; set; }
        public DateTime DtAlteracao { get; set; }
        public float BrutSalario { get; set; }
        public float LiqSalario { get; set; }
    }
}
