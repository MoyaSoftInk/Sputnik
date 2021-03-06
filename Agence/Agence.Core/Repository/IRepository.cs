﻿namespace Agence.Core.Repository
{
    using System.Linq;

    public interface IRepository<TEntity, TKey>
    {
        #region Methods
        /// <summary>
        /// Delete a Element by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Int Value</returns>
        TKey Delete(TKey id);


        /// <summary>
        /// Gets Element by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>TEntity Element</returns>
        TEntity Get(TKey id);

        /// <summary>
        /// Gets All elements TEntity.
        /// </summary>
        /// <returns>IEnumerable<TEntity></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Added TEntity Element.
        /// </summary>
        /// <param name="entity">The TEntity.</param>
        /// <returns>Int value</returns>
        TKey Insert(TEntity entity);

        /// <summary>
        /// Update a Element.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>int value</returns>
        TKey Update(TEntity entity);

        #endregion Methods
    }
}
