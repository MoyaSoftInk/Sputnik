namespace Agence.Domain.Repositories
{
    using Agence.Domain.Entities;
    using System.Linq;

    public interface IPermissaoSistemaRepository
    {
        #region Methods
        /// <summary>
        /// Delete PermissaoSistema
        /// </summary>
        /// <param name="coUsuarioId"></param>
        /// <param name="CoTipoUsuarioId"></param>
        /// <param name="CoSistema"></param>
        /// <returns>PermissaoSistema</returns>
        PermissaoSistema Delete(string coUsuarioId, decimal CoTipoUsuarioId, decimal CoSistemaId);


        /// <summary>
        /// Get a Permissao sistema
        /// </summary>
        /// <param name="coUsuarioId"></param>
        /// <param name="CoTipoUsuarioId"></param>
        /// <param name="CoSistema"></param>
        /// <returns></returns>
        PermissaoSistema Get(string coUsuarioId, decimal CoTipoUsuarioId, decimal CoSistemaId);

        /// <summary>
        /// Gets All elements Permissao sistema.
        /// </summary>
        /// <returns>IEnumerable<TEntity></returns>
        IQueryable<PermissaoSistema> GetAll();

        /// <summary>
        /// Added TEntity Permissao sistema.
        /// </summary>
        /// <param name="entity">The PermissaoSistema.</param>
        /// <returns>string value</returns>
        string Insert(PermissaoSistema entity);

        /// <summary>
        /// Update a Permissao Sistema.
        /// </summary>
        /// <param name="entity">The PermissaoSistema.</param>
        /// <returns>string value</returns>
        string Update(PermissaoSistema entity);

        #endregion Methods
    }
}
