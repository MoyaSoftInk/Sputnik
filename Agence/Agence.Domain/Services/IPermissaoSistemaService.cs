namespace Agence.Domain.Services
{
    using Agence.Domain.Models;
    using System.Collections.Generic;

    public interface IPermissaoSistemaService
    {
        #region Methods

        /// <summary>
        /// Get a Permissao sistema
        /// </summary>
        /// <param name="coUsuarioId"></param>
        /// <param name="CoTipoUsuarioId"></param>
        /// <param name="CoSistema"></param>
        /// <returns></returns>
        PermissaoSistemaModel Get(string coUsuarioId, decimal CoTipoUsuarioId, decimal CoSistemaId);

        /// <summary>
        /// Gets All elements Permissao sistema.
        /// </summary>
        /// <returns>IList<Model></returns>
        IList<PermissaoSistemaModel> Get();

        /// <summary>
        /// Added Model Permissao sistema.
        /// </summary>
        /// <param name="entity">The PermissaoSistema.</param>
        /// <returns>string value</returns>
        string Add(PermissaoSistemaModel permissaoSistemaModel);

        /// <summary>
        /// Update a Permissao Sistema.
        /// </summary>
        /// <param name="permissaoSistemaModel">The PermissaoSistema.</param>
        /// <returns>string value</returns>
        string Update(PermissaoSistemaModel permissaoSistemaModel);

        #endregion Methods
    }
}
