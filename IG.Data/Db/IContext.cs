using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;


namespace IG.Data.Db
{
    public interface IContext
    {
        int SaveChanges();

        void SetModified(object entity);

        void SetAdd(object entity);

        void SetAutoDetect(bool set);

        void DetectChanges();

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

    }
}
