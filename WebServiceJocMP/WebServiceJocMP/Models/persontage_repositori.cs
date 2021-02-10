using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceJocMP.Models
{
    public class persontage_repositori
    {
        private static JocMPEntities dataContext = new JocMPEntities();
        public static List<personatge> GetAllPersonatges()
        {
            try
            {
                List<personatge> lc = dataContext.personatges.ToList();

                return lc;
            }
            catch { return null; }
        }

        public static personatge GetPersonatgeI(int personatgeId)
        {
            try
            {
                personatge lc = dataContext.personatges.Where(x => x.id == personatgeId).SingleOrDefault();

                return lc;
            }
            catch { return null; }
        }

        public static personatge GetPerNom(string name)
        {
            try
            {
                personatge lc = dataContext.personatges.Where(x => x.nom.Contains(name)).SingleOrDefault();

                return lc;
            }
            catch { return null; }
        }

        public static List<personatge> GetPersonesNom(string name)
        {
            try
            {
                List<personatge> lc = dataContext.personatges.Where(x => x.nom.Contains(name)).ToList();

                return lc;
            }
            catch { return null; }
        }
    }
}