using IG.Data.Contracts.Db;
using IG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IG.Data.Db
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        public carelinkPlus_TestEntities DbContext { get; set; }
        internal DbSet<T> DbSet { get; set; }


        public GenericRepository(carelinkPlus_TestEntities context)
        {
            context.Configuration.ProxyCreationEnabled = true;
            DbContext = context;
            DbSet = context.Set<T>();

        }

        public virtual IQueryable<T> GetAll(string[] includes = null)
        {
            return DbSet;
        }

        public virtual IList<T> Find(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Any())
            {

                var query = (DbSet).Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return (query.Where(predicate)).ToList();
            }

            return (DbSet.Where(predicate)).ToList();
        }


        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual T InsertOrUpdate(T entity)
        {
            T ret;
            try
            {
                ret = DbSet.Attach(entity);
                DbContext.Entry(entity).State = EntityState.Modified;

            }
            catch (ModelValidationException ex)
            {
                throw ex;
            }
            return ret;
        }

        public virtual void Delete(object id)
        {
            T entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(T entityToDelete)
        {
            if (entityToDelete == null) return;

            if (DbContext.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
        }

        public virtual void Update(T entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            DbContext.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
