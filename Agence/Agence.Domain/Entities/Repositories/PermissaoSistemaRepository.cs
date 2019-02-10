namespace Agence.Domain.Entities.Repositories
{
    using Agence.Domain.Repositories;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;

    public class PermissaoSistemaRepository : IPermissaoSistemaRepository
    {
        private readonly AgenceDBContext context;
        private readonly DbSet<PermissaoSistema> entities;


        public PermissaoSistemaRepository(AgenceDBContext context)
        {
            this.context = context;
            this.entities = context.Set<PermissaoSistema>();
        }
                

        public PermissaoSistema Delete(string coUsuarioId, decimal CoTipoUsuarioId, decimal CoSistemaId)
        {
            if (string.IsNullOrEmpty(coUsuarioId) || CoTipoUsuarioId.Equals(0) || CoSistemaId.Equals(0))
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                PermissaoSistema entity = this.entities.Where(p => p.CoUsuario.Equals(coUsuarioId) && p.CoTipoUsuario.Equals(CoTipoUsuarioId) && p.CoSistema.Equals(CoSistemaId)).FirstOrDefault();

                this.context.Remove(entity);

                return this.context.SaveChanges() > 0 ? entity : null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public PermissaoSistema Get(string coUsuarioId, decimal CoTipoUsuarioId, decimal CoSistemaId)
        {
            try
            {
                return this.entities.Where(p => p.CoUsuario.Equals(coUsuarioId) && p.CoTipoUsuario.Equals(CoTipoUsuarioId) && p.CoSistema.Equals(CoSistemaId)).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IQueryable<PermissaoSistema> GetAll()
        {
            try
            {
                return this.entities.AsQueryable<PermissaoSistema>();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Insert(PermissaoSistema entity)
        {
            if (entity.Equals(null))
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                this.entities.Add(entity);
                return this.context.SaveChanges() > 0 ? entity.CoUsuario : string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public string Update(PermissaoSistema entity)
        {
            if (entity.Equals(null))
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                this.entities.Update(entity);
                return this.context.SaveChanges() > 0 ? entity.CoUsuario : string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
