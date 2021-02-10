using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceJocMP.Models;

namespace WebServiceJocMP.Controllers
{
    public class monstre_controller : ApiController
    {
        // GET: api/monstre
        [HttpGet]
        [Route("api/monstres")]
        public HttpResponseMessage Get()
        {
            var monstres = monstre_repositori.GetAllMonstres();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, monstres);
            return response;
        }

        [HttpGet]
        [Route("api/monstre/{id?}")]
        public HttpResponseMessage GetMonId(int id)
        {
            var monstres = monstre_repositori.GetMonstreI(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, monstres);
            return response;
        }

        [HttpGet]
        [Route("api/monstren/{name:alpha}")]
        public HttpResponseMessage Get(string name)
        {
            var monstres = monstre_repositori.GetMonNom(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, monstres);
            return response;
        }

        [HttpGet]
        [Route("api/monstresnom/{name:alpha}")]
        public HttpResponseMessage GetMonsNom(string name)
        {
            var monstres = monstre_repositori.GetMonstresNom(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, monstres);
            return response;
        }

        [HttpPut]
        [Route("api/monstrem/{id?}")]
        public HttpResponseMessage Put(int id, [FromBody]monstre val)
        {
            var usuari = monstre_repositori.UpdateMonstre(id, val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, usuari);
            return response;
        }
    }
}
