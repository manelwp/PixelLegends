using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceJocMP.Models;

namespace WebServiceJocMP.Controllers
{
    public class armadura_controller : ApiController
    {
        // GET: api/armadura
        [HttpGet]
        [Route("api/armadures")]
        public HttpResponseMessage Get()
        {
            var armadures = armadura_repositori.GetAllArmadures();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, armadures);
            return response;
        }

        [HttpGet]
        [Route("api/armadura/{id?}")]
        public HttpResponseMessage GetArdId(int id)
        {
            var armaduras = armadura_repositori.GetArmaduraI(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, armaduras);
            return response;
        }

        [HttpGet]
        [Route("api/armaduran/{name:alpha}")]
        public HttpResponseMessage Get(string name)
        {
            var armadures = armadura_repositori.GetArdNom(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, armadures);
            return response;
        }

        [HttpGet]
        [Route("api/armaduresnom/{name:alpha}")]
        public HttpResponseMessage GetArmNom(string name)
        {
            var armadures = armadura_repositori.GetArmadurasNom(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, armadures);
            return response;
        }

        [HttpGet]
        [Route("api/armadurespersonatge/{id?}")]
        public HttpResponseMessage GetArmaduresPer(int id)
        {
            var armadures = armadura_repositori.GetArmadurasPersonatge(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, armadures);
            return response;
        }
    }
}
