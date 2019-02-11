namespace Agence.Domain.Services
{
    using Agence.Domain.Models;
    using System.Collections.Generic;

    public interface ICaoUsuarioService
    {
        #region Methods
        /// <summary>
        /// Added Model Cao Usuario.
        /// </summary>
        /// <param name="caoUsuarioModel"></param>
        /// <returns></returns>
        string Add(CaoUsuarioModel caoUsuarioModel);

        /// <summary>
        /// Gets All elements Cao Usuario.
        /// </summary>
        /// <returns></returns>
        IList<CaoUsuarioModel> Get();

        /// <summary>
        /// Get a Cao Usuario.
        /// </summary>
        /// <param name="coUsuarioId"></param>
        /// <returns></returns>
        CaoUsuarioModel Get(string coUsuarioId);        

        /// <summary>
        /// Update a Cao Usuario.
        /// </summary>
        /// <param name="caoUsuarioModel"></param>
        void Update(CaoUsuarioModel caoUsuarioModel);

        #endregion Methods
    }
}
