using IG.Data.Contracts.Db;
using IG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG.Data.Db
{
    public class BasicUnitofWork : IUnitOfWork
    {
       
        protected carelinkPlus_TestEntities DbContext { get; set; }

        public BasicUnitofWork()
        {
           CreateDbContext();    
        }

        protected void CreateDbContext()
        {
             DbContext = new carelinkPlus_TestEntities();
             DbContext.Configuration.LazyLoadingEnabled = true;
        }

        public IRepository<T> GetGenericRepositoryForEntity<T>() where T : class
        {

            return new GenericRepository<T>(DbContext); ;
          //  return GetGenericRepositoryForEntity<T>();
        }


        public T GetCustomRepositoryOfType<T>() where T : class
        {
            return GetCustomRepositoryOfType<T>();
        }
        
        public void Commit()
        {
            try
            {
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    }

