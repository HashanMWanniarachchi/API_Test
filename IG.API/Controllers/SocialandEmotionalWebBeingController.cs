using IG.Data.Contracts.Db;
using IG.Data.Db;
using IG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace IG.API.Controllers
{
    public class SocialandEmotionalWebBeingController : ApiController
    {
        protected IRepository<tblINIProfile> tblINIProfile { get; set; }
        BasicUnitofWork unitOfWork;

        public SocialandEmotionalWebBeingController()
        {
           unitOfWork = new BasicUnitofWork();
        }

        [ResponseType(typeof(tblINIProfile))]
        public IHttpActionResult GetSocialandEmotionalWebBeing(int id)
        {
            
            return Ok(tblINIProfile);
        }

        public IQueryable<tblINIProfile> GetAllSocialandEmotionalWebBeing()
        {
            tblINIProfile = unitOfWork.GetGenericRepositoryForEntity<tblINIProfile>();
            return tblINIProfile.GetAll().AsQueryable();
           
        }

    }
}
