using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceJocMP.Models;

namespace WebServiceJocMP.Controllers
{
    public class jugador_controller : ApiController
    {
        // GET: api/jugador
        [HttpGet]
        [Route("api/jugadors")]
        public HttpResponseMessage Get()
        {
            var jugadors = jugador_repositori.GetAllJugadors();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, jugadors);
            return response;
        }

        [HttpGet]
        [Route("api/jugador/{id?}")]
        public HttpResponseMessage GetJugId(int id)
        {
            var jugadors = jugador_repositori.GetJugadorI(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, jugadors);
            return response;
        }

        [HttpGet]
        [Route("api/jugadorusu/{id?}")]
        public HttpResponseMessage GetJugUsu(int id)
        {
            var jugadors = jugador_repositori.GetJugadorUsuari(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, jugadors);
            return response;
        }

        [HttpGet]
        [Route("api/jugadorpers/{id?}")]
        public HttpResponseMessage GetJugPer(int id)
        {
            var jugadors = jugador_repositori.GetJugadorPersonatge(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, jugadors);
            return response;
        }

        [HttpGet]
        [Route("api/jugadorn/{name:alpha}")]
        public HttpResponseMessage Get(string name)
        {
            var jugadors = jugador_repositori.GetJugNom(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, jugadors);
            return response;
        }

        [HttpGet]
        [Route("api/jugadornom/{name:alpha}")]
        public HttpResponseMessage GetListNom(string name)
        {
            var jugadors = jugador_repositori.GetJugNomList(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, jugadors);
            return response;
        }

        [HttpPost]
        [Route("api/jugador")]
        public HttpResponseMessage PostJ([FromBody]jugador val)
        {
            var jugadors = jugador_repositori.InsertJugador(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, jugadors);
            return response;
        }

        [HttpPut]
        [Route("api/jugadorj/{id?}")]
        public HttpResponseMessage Put(int id, [FromBody]jugador val)
        {
            var jugador = jugador_repositori.UpdateJugador(id, val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, jugador);
            return response;
        }

        [HttpDelete]
        [Route("api/jugadord/{id?}")]
        public HttpResponseMessage DeleteJ(int id)
        {
            jugador_repositori.DeleteJugador(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [HttpDelete]
        [Route("api/jugadorsusuari/{id?}")]
        public HttpResponseMessage DeleteJugadorsUsuari(int id)
        {
            jugador_repositori.DeleteJugadorsUsuari(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

    }
}
