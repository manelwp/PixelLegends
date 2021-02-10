using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceJocMP.Models;

namespace WebServiceJocMP.Controllers
{
    public class arma_controller : ApiController
    {

        // GET: api/arma
        [HttpGet]
        [Route("api/armes")]
        public HttpResponseMessage Get()
        {
            var armes = arma_repositori.GetAllArmes();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, armes);
            return response;
        }

        [HttpGet]
        [Route("api/arma/{id?}")]
        public HttpResponseMessage GetArmId(int id)
        {
            var armes = arma_repositori.GetArmaI(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, armes);
            return response;
        }

        [HttpGet]
        [Route("api/arman/{name:alpha}")]
        public HttpResponseMessage Get(string name)
        {
            var armas = arma_repositori.GetArmNom(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, armas);
            return response;
        }

        [HttpGet]
        [Route("api/armesnom/{name:alpha}")]
        public HttpResponseMessage GetArmesNom(string name)
        {
            var armas = arma_repositori.GetArmasNom(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, armas);
            return response;
        }

        [HttpGet]
        [Route("api/armespersonatge/{id?}")]
        public HttpResponseMessage GetArmesPer(int id)
        {
            var armas = arma_repositori.GetArmesPersonatge(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, armas);
            return response;
        }
    }
}
