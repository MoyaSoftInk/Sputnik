namespace Agence.Domain.Services.imp
{
    using Agence.Domain.Entities;
    using Agence.Domain.Models;
    using Agence.Domain.Repositories;
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using System.Linq;

    /// <summary>
    /// CaoFaturaService class.
    /// </summary>
    public class CaoFaturaService : ICaoFaturaService
    {
        #region Fields

        ICaoFaturaRepository caoFaturaRepository;

        #endregion Fields

        #region Constructors

        /// Initializes a new instance of the <see cref="CaoFaturaService"/> class.
        /// </summary>
        /// <param name="caoFaturaRepository">The CaoFatura Repository.</param>
        public CaoFaturaService(ICaoFaturaRepository caoFaturaRepository)
        {
            this.caoFaturaRepository = caoFaturaRepository;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Sets a caoFatura by CaoFaturaModel.
        /// </summary>
        /// <param name="CaoFaturaModel">The CaoFaturaModel.</param>
        /// <returns>The id of the CaoFatura</returns>
        public long Add(CaoFaturaModel caoFaturaModel)
        {
            var caoFatura = Mapper.Map<CaoFatura>(caoFaturaModel);

            this.caoFaturaRepository.Insert(caoFatura);

            return caoFatura.CoFatura;
        }

        /// <summary>
        /// Gets all caoFatura.
        /// </summary>
        /// <param></param>
        /// <returns>IEnumerable CaoFatura</returns>
        public IList<CaoFaturaModel> Get()
        {
            try
            {
                IEnumerable<CaoFatura> caoFatura = this.caoFaturaRepository.GetAll();
                return caoFatura.Select(c => Mapper.Map<CaoFaturaModel>(c)).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets a CaoFatura by CoFaturaId.
        /// </summary>
        /// <param name="coFaturaId">The id.</param>
        /// <returns>CaoFatura model</returns>
        public CaoFaturaModel Get(long coFaturaId)
        {
            try
            {
                var caoFatura = this.caoFaturaRepository.Get(coFaturaId);
                return Mapper.Map<CaoFaturaModel>(caoFatura);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Update a CaoFatura by caoFaturaModel.
        /// </summary>
        /// <param name="caoFaturaModel">The caoFaturaModel.</param>
        /// <returns></returns>
        public void Update(CaoFaturaModel caoFaturaModel)
        {
            var caoFatura = Mapper.Map<CaoFatura>(caoFaturaModel);

            this.caoFaturaRepository.Update(caoFatura);
        }

        #endregion Methods
    }
}
