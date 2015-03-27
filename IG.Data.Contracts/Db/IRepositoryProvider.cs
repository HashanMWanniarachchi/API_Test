using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG.Data.Contracts.Db
{
    public interface IRepositoryProvider
    {
        IRepository<T> GetGenericRepositoryForEntity<T>() where T : class;

        T GetCustomRepositoryOfType<T>() where T : class;
    }
}
