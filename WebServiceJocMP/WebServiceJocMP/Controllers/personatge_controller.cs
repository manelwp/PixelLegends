using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceJocMP.Models;

namespace WebServiceJocMP.Controllers
{
    public class personatge_controller : ApiController
    {

        // GET: api/personatges
        [HttpGet]
        [Route("api/personatges")]
        public HttpResponseMessage Get()
        {
            var personatges = persontage_repositori.GetAllPersonatges();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personatges);
            return response;
        }

        [HttpGet]
        [Route("api/personatge/{id?}")]
        public HttpResponseMessage GetPerId(int id)
        {
            var personatges = persontage_repositori.GetPersonatgeI(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personatges);
            return response;
        }

        [HttpGet]
        [Route("api/personatgen/{name:alpha}")]
        public HttpResponseMessage Get(string name)
        {
            var personatges = persontage_repositori.GetPerNom(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personatges);
            return response;
        }

        [HttpGet]
        [Route("api/personatgenom/{name:alpha}")]
        public HttpResponseMessage GetPerNom(string name)
        {
            var personatges = persontage_repositori.GetPersonesNom(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personatges);
            return response;
        }
    }
}
