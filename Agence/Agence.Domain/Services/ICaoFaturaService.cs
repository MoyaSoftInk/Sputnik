namespace Agence.Domain.Services
{
    using Agence.Domain.Models;
    using System.Collections.Generic;

    public interface ICaoFaturaService
    {
        #region Methods
        /// <summary>
        /// Added Model Cao Fatura.
        /// </summary>
        /// <param name="caoFaturaModel"></param>
        /// <returns></returns>
        long Add(CaoFaturaModel caoFaturaModel);

        /// <summary>
        /// Gets All elements Cao Fatura.
        /// </summary>
        /// <returns></returns>
        IList<CaoFaturaModel> Get();

        /// <summary>
        /// Get a Cao Fatura.
        /// </summary>
        /// <param name="coFaturaId"></param>
        /// <returns></returns>
        CaoFaturaModel Get(long coFaturaId);

        /// <summary>
        /// Update a Cao Fatura.
        /// </summary>
        /// <param name="caoFaturaModel"></param>
        void Update(CaoFaturaModel caoFaturaModel);

        #endregion Methods
    }
}
