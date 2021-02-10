using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceJocMP.Models
{
    public class monstre_repositori
    {

        private static JocMPEntities dataContext = new JocMPEntities();
        public static List<monstre> GetAllMonstres()
        {
            try
            {
                List<monstre> lc = dataContext.monstres.ToList();

                return lc;
            }
            catch { return null; }
        }

        public static monstre GetMonstreI(int monstreId)
        {
            try
            {
                monstre lc = dataContext.monstres.Where(x => x.id == monstreId).SingleOrDefault();

                return lc;
            }
            catch { return null; }
        }

        public static monstre GetMonNom(string name)
        {
            try
            {
                monstre lc = dataContext.monstres.Where(x => x.nom.Contains(name)).SingleOrDefault();

                return lc;
            }
            catch { return null; }
        }

        public static List<monstre> GetMonstresNom(string name)
        {
            try
            {
                List<monstre> lc = dataContext.monstres.Where(x => x.nom.Contains(name)).ToList();

                return lc;
            }
            catch { return null; }
        }

        public static monstre UpdateMonstre(int id, monstre m)
        {
            try
            {
                monstre m0 = dataContext.monstres.Where(x => x.id == id).SingleOrDefault();
                if (m.vida != null) m0.vida = m.vida;

                dataContext.SaveChanges();
                return GetMonstreI(m.id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}