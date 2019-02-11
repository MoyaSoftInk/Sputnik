namespace Agence.Domain.Services
{
    using Agence.Domain.Models;
    using System;
    using System.Collections.Generic;

    public interface ICaoSalarioService
    {
        #region Methods

        /// <summary>
        /// Get a CaoSalario.
        /// </summary>
        /// <param name="coUsuarioId"></param>
        /// <param name="dtAlteracaoId"></param>
        /// <returns></returns>
        CaoSalarioModel Get(string coUsuarioId, DateTime dtAlteracaoId);

        /// <summary>
        /// Gets All elements CaoSalario.
        /// </summary>
        /// <returns>IList<Model></returns>
        IList<CaoSalarioModel> Get();

        /// <summary>
        /// Added Model CaoSalario.
        /// </summary>
        /// <param name="entity">The CaoSalario.</param>
        /// <returns>string value</returns>
        string Add(CaoSalarioModel permissaoSistemaModel);

        /// <summary>
        /// Update a CaoSalario.
        /// </summary>
        /// <param name="permissaoSistemaModel">The CaoSalario.</param>
        /// <returns>string value</returns>
        string Update(CaoSalarioModel permissaoSistemaModel);

        #endregion Methods
    }
}
