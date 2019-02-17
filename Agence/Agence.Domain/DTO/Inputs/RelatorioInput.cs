namespace Agence.Domain.DTO.Inputs
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class RelatorioInput
    /// </summary>
    public class RelatorioInput
    {
        public RelatorioInput()
        {
            this.Consultors = new List<Consultor>();
        }

        /// <summary>
        /// Get or Set Consultors
        /// </summary>
        public IList<Consultor> Consultors { get; set; }

        /// <summary>
        /// Get or Set DateInit
        /// </summary>
        public string DateInit { get; set; }

        /// <summary>
        /// Get or Set DateEnd
        /// </summary>
        public string DateEnd { get; set; }
    }
}
