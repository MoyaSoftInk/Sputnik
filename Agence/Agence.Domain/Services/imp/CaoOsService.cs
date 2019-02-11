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
    /// CaoOsService class.
    /// </summary>
    public class CaoOsService : ICaoOsService
    {
        #region Fields

        ICaoOsRepository caoOsRepository;

        #endregion Fields

        #region Constructors

        /// Initializes a new instance of the <see cref="CaoOsService"/> class.
        /// </summary>
        /// <param name="caoOsRepository">The CaoOs Repository.</param>
        public CaoOsService(ICaoOsRepository caoOsRepository)
        {
            this.caoOsRepository = caoOsRepository;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Sets a caoOs by CaoOsModel.
        /// </summary>
        /// <param name="CaoOsModel">The CaoOsModel.</param>
        /// <returns>The id of the CaoOs</returns>
        public int Add(CaoOsModel caoOsModel)
        {
            var caoOs = Mapper.Map<CaoOs>(caoOsModel);

            this.caoOsRepository.Insert(caoOs);

            return caoOs.CoOs;
        }

        /// <summary>
        /// Gets all caoOs.
        /// </summary>
        /// <param></param>
        /// <returns>IEnumerable CaoOs</returns>
        public IList<CaoOsModel> Get()
        {
            try
            {
                IEnumerable<CaoOs> caoOs = this.caoOsRepository.GetAll();
                return caoOs.Select(c => Mapper.Map<CaoOsModel>(c)).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets a CaoOs by CoOsId.
        /// </summary>
        /// <param name="coOsId">The id.</param>
        /// <returns>CaoOs model</returns>
        public CaoOsModel Get(int coOsId)
        {
            try
            {
                var caoOs = this.caoOsRepository.Get(coOsId);
                return Mapper.Map<CaoOsModel>(caoOs);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Update a CaoOs by caoOsModel.
        /// </summary>
        /// <param name="caoOsModel">The caoOsModel.</param>
        /// <returns></returns>
        public void Update(CaoOsModel caoOsModel)
        {
            var caoOs = Mapper.Map<CaoOs>(caoOsModel);

            this.caoOsRepository.Update(caoOs);
        }

        #endregion Methods
    }
}
