using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceJocMP.Models
{
    public class arma_repositori
    {

        private static JocMPEntities dataContext = new JocMPEntities();
        public static List<arma> GetAllArmes()
        {
            try
            {
                List<arma> lc = dataContext.armas.ToList();

                return lc;
            }
            catch { return null; }
        }

        public static arma GetArmaI(int armaId)
        {
            try
            {
                arma lc = dataContext.armas.Where(x => x.id == armaId).SingleOrDefault();

                return lc;
            }
            catch { return null; }
        }

        public static arma GetArmNom(string name)
        {
            try
            {
                arma lc = dataContext.armas.Where(x => x.nom.Contains(name)).SingleOrDefault();

                return lc;
            }
            catch { return null; }
        }

        public static List<arma> GetArmasNom(string name)
        {
            try
            {
                List<arma> lc = dataContext.armas.Where(x => x.nom.Contains(name)).ToList();

                return lc;
            }
            catch { return null; }
        }

        public static List<arma> GetArmesPersonatge(int idpersonatge)
        {
            try
            {
                List<arma> lc = dataContext.armas.Where(x => x.id_personatge == idpersonatge).ToList();

                return lc;
            }
            catch { return null; }
        }
    }
}