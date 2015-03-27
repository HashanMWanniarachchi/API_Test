using IG.Data.Contracts.Db;
using IG.Data.Db;
using IG.Models;
using IG.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace IG.API.Controllers
{
    public class SharedSupportPlanController : ApiController
    {
        protected IRepository<SharedSupportPlan> SharedSupportPlan { get; set; }
        BasicUnitofWork unitOfWork;

        public SharedSupportPlanController()
        {
           unitOfWork = new BasicUnitofWork();
        }

        
        [ResponseType(typeof(SharedSupportPlan))]
        public IQueryable<SharedSupportPlan> GetAllSharedSupportPlan()
        {
            SharedSupportPlan = unitOfWork.GetGenericRepositoryForEntity<SharedSupportPlan>();
            return SharedSupportPlan.GetAll().AsQueryable();

        }
    }
}
