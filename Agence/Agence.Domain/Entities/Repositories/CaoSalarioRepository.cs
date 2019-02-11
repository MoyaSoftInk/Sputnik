namespace Agence.Domain.Entities.Repositories
{
    using Agence.Domain.Repositories;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;

    public class CaoSalarioRepository : ICaoSalarioRepository
    {
        private readonly AgenceDBContext context;
        private readonly DbSet<CaoSalario> entities;


        public CaoSalarioRepository(AgenceDBContext context)
        {
            this.context = context;
            this.entities = context.Set<CaoSalario>();
        }


        public CaoSalario Delete(string coUsuarioId, DateTime dtAlteracaoId)
        {
            if (string.IsNullOrEmpty(coUsuarioId))
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                CaoSalario entity = this.entities.Where(p => p.CoUsuario.Equals(coUsuarioId) && p.DtAlteracao.Equals(dtAlteracaoId)).FirstOrDefault();

                this.context.Remove(entity);

                return this.context.SaveChanges() > 0 ? entity : null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public CaoSalario Get(string coUsuarioId, DateTime dtAlteracaoId)
        {
            try
            {
                return this.entities.Where(p => p.CoUsuario.Equals(coUsuarioId) && p.DtAlteracao.Equals(dtAlteracaoId)).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IQueryable<CaoSalario> GetAll()
        {
            try
            {
                return this.entities.AsQueryable<CaoSalario>();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Insert(CaoSalario entity)
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

        public string Update(CaoSalario entity)
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
