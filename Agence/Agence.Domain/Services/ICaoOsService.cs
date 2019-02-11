namespace Agence.Domain.Services
{
    using Agence.Domain.Models;
    using System.Collections.Generic;

    public interface ICaoOsService
    {
        #region Methods
        /// <summary>
        /// Added Model Cao Os.
        /// </summary>
        /// <param name="caoOsModel"></param>
        /// <returns></returns>
        int Add(CaoOsModel caoOsModel);

        /// <summary>
        /// Gets All elements Cao Os.
        /// </summary>
        /// <returns></returns>
        IList<CaoOsModel> Get();

        /// <summary>
        /// Get a Cao Os.
        /// </summary>
        /// <param name="coOsId"></param>
        /// <returns></returns>
        CaoOsModel Get(int coOsId);

        /// <summary>
        /// Update a Cao Os.
        /// </summary>
        /// <param name="caoOsModel"></param>
        void Update(CaoOsModel caoOsModel);

        #endregion Methods
    }
}
