using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IG.Models.DTO;
using IG.Models;

namespace IG.Data.Repositories
{
    class PallativeCareRepository : IPallativeCareRepository
    {
        carelinkPlus_TestEntities DbContext = new carelinkPlus_TestEntities();
       
    }
}
