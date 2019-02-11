namespace Agence.Domain.DTO
{
    using System.Collections.Generic;

    /// <summary>
    /// Class RelatorioDTO
    /// </summary>
    public class RelatorioDTO
    {
        public RelatorioDTO()
        {
            this.RelatorioDetails = new List<RelatorioDetail>();
        }

        /// <summary>
        /// Get or Set CoUsuario
        /// </summary>
        public string CoUsuario { get; set; }

        /// <summary>
        /// Get or Set NoUsuario
        /// </summary>
        public string NoUsuario { get; set; }

        /// <summary>
        /// Get or Set TotalReceitaLiquida
        /// </summary>
        public decimal TotalReceitaLiquida { get; set; }

        /// <summary>
        /// Get or Set TotalCustoFixo
        /// </summary>
        public decimal TotalCustoFixo { get; set; }

        /// <summary>
        /// Get or Set TotalComissao
        /// </summary>
        public decimal TotalComissao { get; set; }

        /// <summary>
        /// Get or Set TotalLucro
        /// </summary>
        public decimal TotalLucro { get; set; }

        /// <summary>
        /// Get or Set RelatorioDetails
        /// </summary>
        public IList<RelatorioDetail> RelatorioDetails { get; set; }

    }

    /// <summary>
    /// Class RelatorioDetail, contain all detail of the consultors
    /// </summary>
    public class RelatorioDetail
    {
        public RelatorioDetail()
        {

        }

        /// <summary>
        /// Get or Set Date expresed in a string.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Get or Set ReceitaLiquida
        /// </summary>
        public decimal ReceitaLiquida { get; set; }

        /// <summary>
        /// Get or Set CustoFixo
        /// </summary>
        public decimal CustoFixo { get; set; }

        /// <summary>
        /// Get or Set Comissao
        /// </summary>
        public decimal Comissao { get; set; }

        /// <summary>
        /// Get or Set Lucro
        /// </summary>
        public decimal Lucro { get; set; }
    }
}
