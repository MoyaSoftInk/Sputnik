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
    public class PermissaoSistemaService : IPermissaoSistemaService
    {
        #region Fields

        IPermissaoSistemaRepository permissaoSistemaRepository;

        #endregion Fields

        #region Constructors

        /// Initializes a new instance of the <see cref="PermissaoSistemaService"/> class.
        /// </summary>
        /// <param name="permissaoSistemaRepository">The CaoUsuar Repository.</param>
        public PermissaoSistemaService(IPermissaoSistemaRepository permissaoSistemaRepository)
        {
            this.permissaoSistemaRepository = permissaoSistemaRepository;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Sets a permissaoSistemaio by permissaoSistemaModel.
        /// </summary>
        /// <param name="permissaoSistemaModel">The permissaoSistemaModel.</param>
        /// <returns>The CoUsuario of the permissaoSistema</returns>
        public string Add(PermissaoSistemaModel permissaoSistemaModel)
        {
            var permissaoSistema = Mapper.Map<PermissaoSistema>(permissaoSistemaModel);

            this.permissaoSistemaRepository.Insert(permissaoSistema);

            return permissaoSistema.CoUsuario;
        }

        /// <summary>
        /// Gets all permissaoSistemaio.
        /// </summary>
        /// <param></param>
        /// <returns>IEnumerable CaoUsuar</returns>
        public IList<PermissaoSistemaModel> Get()
        {
            IEnumerable<PermissaoSistema> permissaoSistema = this.permissaoSistemaRepository.GetAll();
            return permissaoSistema.Select(c => Mapper.Map<PermissaoSistemaModel>(c)).ToList();
        }

        /// <summary>
        /// Gets a CaoUsuar by CoUsuarioId.
        /// </summary>
        /// <param name="coUsuarioId">The id.</param>
        /// <returns>PermissaoSistema model</returns>
        public PermissaoSistemaModel Get(string coUsuarioId, decimal CoTipoUsuarioId, decimal CoSistemaId)
        {
            if (string.IsNullOrEmpty(coUsuarioId))
                new ArgumentException("parámetro inválido", coUsuarioId);

            var permissaoSistema = this.permissaoSistemaRepository.Get(coUsuarioId, CoTipoUsuarioId, CoSistemaId);
            return Mapper.Map<PermissaoSistemaModel>(permissaoSistema);
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
        //        requests = this.permissaoSistemaRepository.GetPaged(specificationModel.PageIndex - 1, specificationModel.PageSize, filter.SatisfiedBy(), orderExp);

        //    }
        //    else
        //    {
        //        requests = this.permissaoSistemaRepository.GetPaged(specificationModel.PageIndex - 1, specificationModel.PageSize, c => true, orderExp, ascending);
        //    }

        //    returnData = new PagedElements<CaoUsuar>(requests.Elements.AsQueryable(), requests.TotalElements);

        //    return returnData;
        //}

        /// <summary>
        /// Update a CaoUsuar by permissaoSistemaioModel.
        /// </summary>
        /// <param name="permissaoSistemaioModel">The permissaoSistemaioModel.</param>
        /// <returns></returns>
        public string Update(PermissaoSistemaModel permissaoSistemaioModel)
        {
            var permissaoSistema = Mapper.Map<PermissaoSistema>(permissaoSistemaioModel);

            this.permissaoSistemaRepository.Update(permissaoSistema);

            return permissaoSistema.CoUsuario;
        }

        #endregion Methods
    }

}