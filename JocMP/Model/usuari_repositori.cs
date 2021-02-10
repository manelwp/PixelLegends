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
    public class usuari_repositori
    {
        public static string jocmp = "https://localhost:44363/api/";

        public static usuari InsertUsuari(usuari us)
        {
            try
            {
                usuari u = (usuari)MakeRequest(string.Concat(jocmp, "usuari/"), us, "POST", "application/json", typeof(usuari));
                return u;
            }
            catch { return null; }
        }

        public static usuari GetUsuariName(string nom)
        {
            usuari u = (usuari)MakeRequest(string.Concat(jocmp, "usuarin/" + nom), null, "GET", "application/json", typeof(usuari));
            return u;
        }

        public static List<usuari> GetUsuarisNom(string nom)
        {
            List<usuari> lu = (List<usuari>)MakeRequest(string.Concat(jocmp, "usuarisnom/" + nom), null, "GET", "application/json", typeof(List<usuari>));
            return lu;
        }

        public static usuari UpdateUsuari(int id, usuari usu)
        {
            try
            {
                usuari u = (usuari)MakeRequest(string.Concat(jocmp, "usuariu/" + id), usu, "PUT", "application/json", typeof(usuari));
                return u;
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
