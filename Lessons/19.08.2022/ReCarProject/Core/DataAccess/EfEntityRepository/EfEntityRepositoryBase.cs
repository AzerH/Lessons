using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EfEntityRepository
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new() 
        where TContext : DbContext, new() 
    {
        public void Add(TEntity entity)
        {
            using (TContext contex = new TContext())
            {
                var carForAdd = contex.Entry(entity);
                carForAdd.State = EntityState.Added;
                contex.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var carForDelete = context.Entry(entity);
                carForDelete.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();


            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);

            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var carForUpdate = context.Entry(entity);
                carForUpdate.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
