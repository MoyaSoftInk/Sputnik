namespace Agence.Domain.Services.imp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Agence.Domain.Entities;
    using Agence.Domain.Models;
    using Agence.Domain.Repositories;
    using AutoMapper;

    /// <summary>
    /// CaoUsuarService class.
    /// </summary>
    public class CaoUsuarioService : ICaoUsuarioService
    {
        #region Fields

        ICaoUsuarioRepository caoUsuarRepository;

        #endregion Fields

        #region Constructors

        /// Initializes a new instance of the <see cref="CaoUsuarioService"/> class.
        /// </summary>
        /// <param name="caoUsuarRepository">The CaoUsuar Repository.</param>
        public CaoUsuarioService(ICaoUsuarioRepository caoUsuarRepository)
        {
            this.caoUsuarRepository = caoUsuarRepository;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Sets a caoUsuario by CaoUsuarModel.
        /// </summary>
        /// <param name="CaoUsuarModel">The CaoUsuarModel.</param>
        /// <returns>The id of the CaoUsuar</returns>
        public string Add(CaoUsuarioModel caoUsuarModel)
        {
            var caoUsuar = Mapper.Map<CaoUsuario>(caoUsuarModel);

            this.caoUsuarRepository.Insert(caoUsuar);

            return caoUsuar.CoUsuario;
        }

        /// <summary>
        /// Gets all caoUsuario.
        /// </summary>
        /// <param></param>
        /// <returns>IEnumerable CaoUsuar</returns>
        public IList<CaoUsuarioModel> Get()
        {
            try
            {
                IEnumerable<CaoUsuario> caoUsuar = this.caoUsuarRepository.GetAll();
                return caoUsuar.Select(c => Mapper.Map<CaoUsuarioModel>(c)).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets a CaoUsuar by CoUsuarioId.
        /// </summary>
        /// <param name="coUsuarioId">The id.</param>
        /// <returns>CaoUsuario model</returns>
        public CaoUsuarioModel Get(string coUsuarioId)
        {
            try
            {
                if (string.IsNullOrEmpty(coUsuarioId))
                    new ArgumentException("parámetro inválido", coUsuarioId);

                var caoUsuar = this.caoUsuarRepository.Get(coUsuarioId);
                return Mapper.Map<CaoUsuarioModel>(caoUsuar);
            }
            catch (Exception)
            {
                return null;
            }
        }

        //public PagedElements<CaoUsuar> Get(SpecificationModel specificationModel)
        //{
        //    /* if (specificationModel.Where != null)
        //         specificationModel.Where.rules[0].data = Helpers.decode(specificationModel.Where.rules[0].data);*/
        //    Guard.IsNotNull(specificationModel, "specificationModel");


        //    bool ascending = false;

        //    // Set the sort order
        //    if (specificationModel.SortOrder == "asc")
        //    {
        //        ascending = true;
        //    }

        //    PagedElements<CaoUsuar> requests = null;
        //    PagedElements<CaoUsuar> returnData = null;


        //    Expression<Func<CaoUsuar, object>> orderExp;
        //    if (specificationModel.SortColumn == "Code")
        //        orderExp = u => u.Code;
        //    else if (specificationModel.SortColumn == "Name")
        //        orderExp = u => u.Name;
        //    else
        //        orderExp = u => u.CreatedAt;

        //    if (specificationModel.IsSearch)
        //    {
        //        Rule[] rules = specificationModel.Where.rules;
        //        foreach (Rule rule in rules)
        //        {

        //        }

        //        ISpecification<CaoUsuar> filter = specificationModel.ToSpecification<CaoUsuar>();
        //        requests = this.caoUsuarRepository.GetPaged(specificationModel.PageIndex - 1, specificationModel.PageSize, filter.SatisfiedBy(), orderExp);

        //    }
        //    else
        //    {
        //        requests = this.caoUsuarRepository.GetPaged(specificationModel.PageIndex - 1, specificationModel.PageSize, c => true, orderExp, ascending);
        //    }

        //    returnData = new PagedElements<CaoUsuar>(requests.Elements.AsQueryable(), requests.TotalElements);

        //    return returnData;
        //}

        /// <summary>
        /// Update a CaoUsuar by caoUsuarioModel.
        /// </summary>
        /// <param name="caoUsuarioModel">The caoUsuarioModel.</param>
        /// <returns></returns>
        public void Update(CaoUsuarioModel caoUsuarioModel)
        {
            var caoUsuar = Mapper.Map<CaoUsuario>(caoUsuarioModel);

            this.caoUsuarRepository.Update(caoUsuar);
        }

        #endregion Methods
    }

}