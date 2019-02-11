namespace Agence.Domain.Repositories
{
    using Agence.Domain.Entities;
    using System;
    using System.Linq;

    public interface ICaoSalarioRepository
    {
        #region Methods

        /// <summary>
        /// Delete CaoSalario.
        /// </summary>
        /// <param name="coUsuarioId"></param>
        /// <param name="dtAlteracaoId"></param>
        /// <returns>CaoSalario</returns>
        CaoSalario Delete(string coUsuarioId, DateTime dtAlteracaoId);


        /// <summary>
        /// Get a CaoSalario.
        /// </summary>
        /// <param name="coUsuarioId"></param>
        /// <param name="CoTipoUsuarioId"></param>
        /// <param name="CoSistema"></param>
        /// <returns></returns>
        CaoSalario Get(string coUsuarioId, DateTime dtAlteracaoId);

        /// <summary>
        /// Gets All elements CaoSalario.
        /// </summary>
        /// <returns>IEnumerable<TEntity></returns>
        IQueryable<CaoSalario> GetAll();

        /// <summary>
        /// Added TEntity CaoSalario.
        /// </summary>
        /// <param name="entity">The CaoSalario.</param>
        /// <returns>string value</returns>
        string Insert(CaoSalario entity);

        /// <summary>
        /// Update a CaoSalario.
        /// </summary>
        /// <param name="entity">The CaoSalario.</param>
        /// <returns>string value</returns>
        string Update(CaoSalario entity);

        #endregion Methods
    }
}
