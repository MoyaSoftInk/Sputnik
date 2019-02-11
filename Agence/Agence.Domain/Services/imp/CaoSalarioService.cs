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
    public class CaoSalarioService : ICaoSalarioService
    {
        #region Fields

        ICaoSalarioRepository caoSalarioRepository;

        #endregion Fields

        #region Constructors

        /// Initializes a new instance of the <see cref="CaoSalarioService"/> class.
        /// </summary>
        /// <param name="caoSalarioRepository">The caoSalario Repository.</param>
        public CaoSalarioService(ICaoSalarioRepository caoSalarioRepository)
        {
            this.caoSalarioRepository = caoSalarioRepository;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Sets a caoSalarioio by caoSalarioModel.
        /// </summary>
        /// <param name="caoSalarioModel">The caoSalarioModel.</param>
        /// <returns>The CoUsuario of the caoSalario</returns>
        public string Add(CaoSalarioModel caoSalarioModel)
        {
            var caoSalario = Mapper.Map<CaoSalario>(caoSalarioModel);

            this.caoSalarioRepository.Insert(caoSalario);

            return caoSalario.CoUsuario;
        }

        /// <summary>
        /// Gets all caoSalarioio.
        /// </summary>
        /// <param></param>
        /// <returns>IEnumerable CaoUsuar</returns>
        public IList<CaoSalarioModel> Get()
        {
            IEnumerable<CaoSalario> caoSalario = this.caoSalarioRepository.GetAll();
            return caoSalario.Select(c => Mapper.Map<CaoSalarioModel>(c)).ToList();
        }

        /// <summary>
        /// Gets a CaoUsuar by CoUsuarioId.
        /// </summary>
        /// <param name="coUsuarioId">The id.</param>
        /// <returns>CaoSalario model</returns>
        public CaoSalarioModel Get(string coUsuarioId, DateTime dtAlteracaoId)
        {
            if (string.IsNullOrEmpty(coUsuarioId))
                new ArgumentException("parámetro inválido", coUsuarioId);

            var caoSalario = this.caoSalarioRepository.Get(coUsuarioId, dtAlteracaoId);
            return Mapper.Map<CaoSalarioModel>(caoSalario);
        }

        /// <summary>
        /// Update a CaoUsuar by caoSalarioioModel.
        /// </summary>
        /// <param name="caoSalarioioModel">The caoSalarioioModel.</param>
        /// <returns></returns>
        public string Update(CaoSalarioModel caoSalarioioModel)
        {
            var caoSalario = Mapper.Map<CaoSalario>(caoSalarioioModel);

            this.caoSalarioRepository.Update(caoSalario);

            return caoSalario.CoUsuario;
        }

        #endregion Methods
    }

}