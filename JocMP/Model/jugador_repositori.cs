using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class jugador_repositori
    {

        public static string jocmp = "https://localhost:44363/api/";

        public static jugador InsertJugador(jugador jug)
        {
            try
            {
                jugador j = (jugador)MakeRequest(string.Concat(jocmp, "jugador/"), jug, "POST", "application/json", typeof(jugador));
                return j;
            }
            catch { return null; }
        }

        public List<jugador> GetAllJugador()
        {
            List<jugador> j = (List<jugador>)MakeRequest(string.Concat(jocmp, "jugadors"), null, "GET", "application/json", typeof(List<jugador>));
            return j;
        }

        public static jugador GetJugadorName(string nom)
        {
            jugador j = (jugador)MakeRequest(string.Concat(jocmp, "jugadorn/" + nom), null, "GET", "application/json", typeof(jugador));
            return j;
        }

        public List<jugador> GetJugadorNameList(string nom)
        {
            List<jugador> j = (List<jugador>)MakeRequest(string.Concat(jocmp, "jugadornom/" + nom), null, "GET", "application/json", typeof(List<jugador>));
            return j;
        }

        public static jugador GetJugadorId(int id)
        {
            jugador j = (jugador)MakeRequest(string.Concat(jocmp, "jugador/" + id), null, "GET", "application/json", typeof(jugador));
            return j;
        }

        public static List<jugador> GetJugadorIdList(int id)
        {
            List<jugador> j = (List<jugador>)MakeRequest(string.Concat(jocmp, "jugador/" + id), null, "GET", "application/json", typeof(List<jugador>));
            return j;
        }

        public static jugador GetJugadorUsuariId(int id)
        {
            jugador j = (jugador)MakeRequest(string.Concat(jocmp, "jugadorusu/" + id), null, "GET", "application/json", typeof(jugador));
            return j;
        }

        public static List<jugador> GetJugadorUsuariIdList(int id)
        {
            List<jugador> j = (List<jugador>)MakeRequest(string.Concat(jocmp, "jugadorusu/" + id), null, "GET", "application/json", typeof(List<jugador>));
            return j;
        }

        public static jugador UpdateJugador(int id, jugador jug)
        {
            try
            {
                jugador j = (jugador)MakeRequest(string.Concat(jocmp, "jugadorj/" + id), jug, "PUT", "application/json", typeof(jugador));
                return j;
            }
            catch { return null; }
        }

        public static object MakeRequest(string requestUrl, object JSONRequest, string JSONmethod, string JSONContentType, Type JSONResponseType)
        //  requestUrl: Url completa del Web Service, amb l'opció sol·licitada
        //  JSONrequest: objecte que se li passa en el body (només per a POST/PUT)
        //  JSONmethod: "GET"/"POST"/"PUT"/"DELETE"
        //  JSONContentType: "application/json" en els casos que el Web Service torni objectes
        //  JSONRensponseType:  tipus d'objecte que torna el Web Service (typeof(tipus))
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest; //WebRequest WR = WebRequest.Create(requestUrl);   
                string sb = JsonConvert.SerializeObject(JSONRequest);
                request.Method = JSONmethod;  // "GET"/"POST"/"PUT"/"DELETE";  

                if (JSONmethod != "GET")
                {
                    request.ContentType = JSONContentType; // "application/json";   
                    Byte[] bt = Encoding.UTF8.GetBytes(sb);
                    Stream st = request.GetRequestStream();
                    st.Write(bt, 0, bt.Length);
                    st.Close();
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));

                    Stream stream1 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream1);
                    string strsb = sr.ReadToEnd();
                    object objResponse = JsonConvert.DeserializeObject(strsb, JSONResponseType);
                    return objResponse;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
