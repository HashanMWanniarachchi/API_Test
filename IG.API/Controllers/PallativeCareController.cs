using IG.Data.Contracts.Db;
using IG.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IG.Data.Db;
using System.Web.Http.Description;

namespace IG.API.Controllers
{
    public class PallativeCareController : ApiController
    {
        protected IRepository<PallativeCareDTO> PallativeCareDTORepository { get; set; }


        public PallativeCareController()
        {
            var unitOfWork = new BasicUnitofWork();
        }

        // GET: api/InformationExchange/5
        [HttpGet]
        public IHttpActionResult GetPallativeCare(int id)
        {
           
            return Ok();
        }
    }
}
