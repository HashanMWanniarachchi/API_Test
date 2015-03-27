using IG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IG.Data.Contracts.Db
{
    public interface IRepository<T> where T : class
    {
        carelinkPlus_TestEntities DbContext { get; set; }

        IQueryable<T> GetAll(string[] includes = null);

        IList<T> Find(Expression<Func<T, bool>> predicate, string[] includes = null);

        T GetById(int id);

        T InsertOrUpdate(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(object id);

    }
}
