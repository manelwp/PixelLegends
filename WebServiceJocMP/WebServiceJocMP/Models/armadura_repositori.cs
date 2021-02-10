using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceJocMP.Models
{
    public class armadura_repositori
    {
        private static JocMPEntities dataContext = new JocMPEntities();
        public static List<armadura> GetAllArmadures()
        {
            try
            {
                List<armadura> lc = dataContext.armaduras.ToList();

                return lc;
            }
            catch { return null; }
        }

        public static armadura GetArmaduraI(int armaduraId)
        {
            try
            {
                armadura lc = dataContext.armaduras.Where(x => x.id == armaduraId).SingleOrDefault();

                return lc;
            }
            catch { return null; }
        }

        public static armadura GetArdNom(string name)
        {
            try
            {
                armadura lc = dataContext.armaduras.Where(x => x.nom.Contains(name)).SingleOrDefault();

                return lc;
            }
            catch { return null; }
        }

        public static List<armadura> GetArmadurasNom(string name)
        {
            try
            {
                List<armadura> lc = dataContext.armaduras.Where(x => x.nom.Contains(name)).ToList();

                return lc;
            }
            catch { return null; }
        }

        public static List<armadura> GetArmadurasPersonatge(int idpersonatge)
        {
            try
            {
                List<armadura> lc = dataContext.armaduras.Where(x => x.id_personatge == idpersonatge).ToList();

                return lc;
            }
            catch { return null; }
        }
    }
}