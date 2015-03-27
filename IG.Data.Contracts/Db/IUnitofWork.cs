using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG.Data.Contracts.Db
{
    public interface IUnitOfWork : IRepositoryProvider
    {
        void Commit();

        void Dispose();
    }
}
