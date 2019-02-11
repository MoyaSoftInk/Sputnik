namespace Agence.Domain.Entities.Repositories
{
    using System;
    using System.Linq;
    using Agence.Domain.Repositories;
    using Microsoft.EntityFrameworkCore;

    public class CaoOsRepository : ICaoOsRepository
    {
        private readonly AgenceDBContext context;
        private readonly DbSet<CaoOs> entities;


        public CaoOsRepository(AgenceDBContext context)
        {
            this.context = context;
            this.entities = context.Set<CaoOs>();
        }

        public int Delete(int caoOsId)
        {
            try
            {
                CaoOs entity = this.entities.Where(p => p.CoOs.Equals(caoOsId)).FirstOrDefault();

                this.context.Remove(entity);

                return this.context.SaveChanges() > 0 ? entity.CoOs : 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public CaoOs Get(int caoOsId)
        {
            try
            {
                return this.entities.Where(p => p.CoOs.Equals(caoOsId)).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IQueryable<CaoOs> GetAll()
        {
            try
            {
                return this.entities.AsQueryable<CaoOs>();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Insert(CaoOs entity)
        {
            if (entity.Equals(null))
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                this.entities.Add(entity);
                return this.context.SaveChanges() > 0 ? entity.CoOs : 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Update(CaoOs entity)
        {
            if (entity.Equals(null))
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                this.entities.Update(entity);
                return this.context.SaveChanges() > 0 ? entity.CoOs : 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
