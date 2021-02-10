using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceJocMP.Models;

namespace WebServiceJocMP.Controllers
{
    public class usuari_controller : ApiController
    {
        // GET: api/usuari
        [HttpGet]
        [Route("api/usuaris")]
        public HttpResponseMessage Get()
        {
            var usuaris = usuari_repositori.GetAllUsuaris();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, usuaris);
            return response;
        }

        [HttpGet]
        [Route("api/usuari/{id?}")]
        public HttpResponseMessage GetUsuId(int id)
        {
            var usuaris = usuari_repositori.GetUsuariI(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, usuaris);
            return response;
        }

        [HttpGet]
        [Route("api/usuarin/{name:alpha}")]
        public HttpResponseMessage Get(string name)
        {
            var usuaris = usuari_repositori.GetUsuNom(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, usuaris);
            return response;
        }

        [HttpGet]
        [Route("api/usuarisnom/{name:alpha}")]
        public HttpResponseMessage GetUsuarisNom(string name)
        {
            var usuaris = usuari_repositori.GetUsuarisNom(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, usuaris);
            return response;
        }

        [HttpPut]
        [Route("api/usuariu/{id?}")]
        public HttpResponseMessage Put(int id, [FromBody]usuari val)
        {
            var usuari = usuari_repositori.UpdateUsuari(id, val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, usuari);
            return response;
        }

        [HttpPost]
        [Route("api/usuari")]
        public HttpResponseMessage PostU([FromBody]usuari val)
        {
            var usuaris = usuari_repositori.InsertUsuari(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, usuaris);
            return response;
        }

        [HttpDelete]
        [Route("api/usuarid/{id?}")]
        public HttpResponseMessage DeleteU(int id)
        {
            usuari_repositori.DeleteUsuari(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

    }
}
