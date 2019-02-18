namespace Agence.Domain.Services
{
    using Agence.Domain.DTO.Inputs;
    using Agence.Domain.Responses;

    public interface IConsultorService
    {
        /// <summary>
        /// List consultors
        /// </summary>
        /// <returns></returns>
        ConsultorResponse GetConsultor();

        /// <summary>
        /// Get relatorio of consultors
        /// </summary>
        /// <param name="relatorioInput"></param>
        /// <returns></returns>
        RelatorioResponse GetRelatorio(RelatorioInput relatorioInput);

        /// <summary>
        /// Get graphics of consultors
        /// </summary>
        /// <param name="relatorioInput"></param>
        /// <returns></returns>
        GraphicsResponse GetGraphics(RelatorioInput relatorioInput);
    }
}
