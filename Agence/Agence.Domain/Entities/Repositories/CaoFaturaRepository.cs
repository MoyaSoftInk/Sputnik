namespace Agence.Domain.Entities.Repositories
{
    using System;
    using System.Linq;
    using Agence.Domain.Repositories;
    using Microsoft.EntityFrameworkCore;

    public class CaoFaturaRepository : ICaoFaturaRepository
    {
        private readonly AgenceDBContext context;
        private readonly DbSet<CaoFatura> entities;


        public CaoFaturaRepository(AgenceDBContext context)
        {
            this.context = context;
            this.entities = context.Set<CaoFatura>();
        }

        public long Delete(long caoFaturaId)
        {
            try
            {
                CaoFatura entity = this.entities.Where(p => p.CoFatura.Equals(caoFaturaId)).FirstOrDefault();

                this.context.Remove(entity);

                return this.context.SaveChanges() > 0 ? entity.CoFatura : 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public CaoFatura Get(long caoFaturaId)
        {
            try
            {
                return this.entities.Where(p => p.CoFatura.Equals(caoFaturaId)).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IQueryable<CaoFatura> GetAll()
        {
            try
            {
                return this.entities.AsQueryable<CaoFatura>();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public long Insert(CaoFatura entity)
        {
            if (entity.Equals(null))
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                this.entities.Add(entity);
                return this.context.SaveChanges() > 0 ? entity.CoFatura : 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public long Update(CaoFatura entity)
        {
            if (entity.Equals(null))
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                this.entities.Update(entity);
                return this.context.SaveChanges() > 0 ? entity.CoFatura : 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
