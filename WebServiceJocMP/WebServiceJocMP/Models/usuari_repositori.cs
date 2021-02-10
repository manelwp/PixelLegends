using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceJocMP.Models
{
    public class usuari_repositori
    {
        private static JocMPEntities dataContext = new JocMPEntities();
        public static List<usuari> GetAllUsuaris()
        {
            try
            {
                List<usuari> lc = dataContext.usuaris.ToList();

                return lc;
            }
            catch { return null; }
        }


        public static usuari GetUsuariI(int usuariId)
        {
            try
            {
                usuari lc = dataContext.usuaris.Where(x => x.id == usuariId).SingleOrDefault();

                return lc;
            }
            catch { return null; }
        }

        public static usuari GetUsuNom(string name)
        {
            try
            {
                usuari lc = dataContext.usuaris.Where(x => x.nom.Contains(name)).SingleOrDefault();

                return lc;
            }
            catch { return null; }
        }

        public static List<usuari> GetUsuarisNom(string name)
        {
            try
            {
                List<usuari> lc = dataContext.usuaris.Where(x => x.nom.Contains(name)).ToList();

                return lc;
            }
            catch { return null; }
        }

        public static usuari InsertUsuari(usuari u)
        {
            try
            {
                dataContext.usuaris.Add(u);
                dataContext.SaveChanges();
                return GetUsuId(u.id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static usuari UpdateUsuari(int id, usuari u)
        {
            try
            {
                usuari u0 = dataContext.usuaris.Where(x => x.id == id).SingleOrDefault();
                if (u.secret != null) u0.secret = u.secret;

                dataContext.SaveChanges();
                return GetUsuId(u.id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void DeleteUsuari(int id)
        {
            try
            {
                usuari c = dataContext.usuaris.Where(x => x.id == id).SingleOrDefault();
                if (c != null)
                {
                    dataContext.usuaris.Remove(c);
                    dataContext.SaveChanges();
                }
            }
            catch { }
        }

        public static usuari GetUsuId(int usuariId)
        {
            usuari u = null;
            try
            {
                u = dataContext.usuaris.Where(x => x.id == usuariId).SingleOrDefault();

                return u;
            }
            catch { }
            return u;
        }

    }
}