namespace Agence.Domain.Entities.Repositories
{
    using System;
    using System.Linq;
    using Agence.Domain.Repositories;
    using Microsoft.EntityFrameworkCore;

    public class CaoUsuarioRepository : ICaoUsuarioRepository
    {
        private readonly AgenceDBContext context;
        private readonly DbSet<CaoUsuario> entities;


        public CaoUsuarioRepository(AgenceDBContext context)
        {
            this.context = context;
            this.entities = context.Set<CaoUsuario>();
        }

        public string Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                CaoUsuario entity = this.entities.Where(p => p.CoUsuario.Equals(id)).FirstOrDefault();

                this.context.Remove(entity);

                return this.context.SaveChanges() > 0 ? id : string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public CaoUsuario Get(string id)
        {
            try
            {
                return this.entities.Where(p => p.CoUsuario.Equals(id)).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IQueryable<CaoUsuario> GetAll()
        {
            try
            {
                return this.entities.AsQueryable<CaoUsuario>();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Insert(CaoUsuario entity)
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

        public string Update(CaoUsuario entity)
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
