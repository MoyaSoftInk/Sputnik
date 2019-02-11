namespace Agence.Domain.Responses
{
    using Agence.Core.Model.Response;
    using Agence.Domain.DTO;
    using System.Collections.Generic;

    /// <summary>
    /// Class Relatorio Response
    /// </summary>
    public class RelatorioResponse : BaseResponse
    {
        public RelatorioResponse()
        {
            this.Relatorios = new List<RelatorioDTO>();
        }

        /// <summary>
        /// Get or Set Relatorio
        /// </summary>
        public IList<RelatorioDTO> Relatorios { get; set; }
    }
}
