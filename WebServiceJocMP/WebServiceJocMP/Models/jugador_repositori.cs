using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceJocMP.Models
{
    public class jugador_repositori
    {
        private static JocMPEntities dataContext = new JocMPEntities();
        public static List<jugador> GetAllJugadors()
        {
            try
            {
                List<jugador> lc = dataContext.jugadors.ToList();

                return lc;
            }
            catch { return null; }
        }

        public static jugador GetJugadorI(int jugadorId)
        {
            try
            {
                jugador lc = dataContext.jugadors.Where(x => x.id == jugadorId).SingleOrDefault();

                return lc;
            }
            catch { return null; }
        }

        public static List<jugador> GetJugadorUsuari(int usuariId)
        {
            try
            {
                List<jugador> lc = dataContext.jugadors.Where(x => x.id_usuari == usuariId).ToList();

                return lc;
            }
            catch { return null; }
        }

        public static List<jugador> GetJugadorPersonatge(int idpersonatge)
        {
            try
            {
                List<jugador> lc = dataContext.jugadors.Where(x => x.id_personatge == idpersonatge).ToList();

                return lc;
            }
            catch { return null; }
        }

        public static jugador GetJugNom(string name)
        {
            try
            {
                jugador lc = dataContext.jugadors.Where(x => x.nom.Contains(name)).SingleOrDefault();

                return lc;
            }
            catch { return null; }
        }

        public static List<jugador> GetJugNomList(string name)
        {
            try
            {
                List<jugador> lc = dataContext.jugadors.Where(x => x.nom.Contains(name)).ToList();

                return lc;
            }
            catch { return null; }
        }

        public static jugador InsertJugador(jugador j)
        {
            try
            {
                dataContext.jugadors.Add(j);
                dataContext.SaveChanges();
                return GetJugId(j.id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static jugador GetJugId(int jugadorId)
        {
            jugador j = null;
            try
            {
                j = dataContext.jugadors.Where(x => x.id == jugadorId).SingleOrDefault();

                return j;
            }
            catch { }
            return j;
        }

        public static jugador UpdateJugador(int id, jugador u)
        {
            try
            {
                jugador u0 = dataContext.jugadors.Where(x => x.id == id).SingleOrDefault();
                if (u.id_armadura != null) u0.id_armadura = u.id_armadura;
                if (u.id_arma != null) u0.id_arma = u.id_arma;
                if (u.nivell != null) u0.nivell = u.nivell;
                if (u.atac != null) u0.atac = u.atac;
                if (u.vida != null) u0.vida = u.vida;
                if (u.defensa != null) u0.defensa = u.defensa;
                if (u.atac_especial != null) u0.atac_especial = u.atac_especial;
                if (u.defensa_especial != null) u0.defensa_especial = u.defensa_especial;

                dataContext.SaveChanges();
                return GetJugId(u.id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void DeleteJugador(int id)
        {
            try
            {
                jugador c = dataContext.jugadors.Where(x => x.id == id).SingleOrDefault();
                if (c != null)
                {
                    dataContext.jugadors.Remove(c);
                    dataContext.SaveChanges();
                }
            }
            catch { }
        }

        public static void DeleteJugadorsUsuari(int id_usuari)
        {
            try
            {
                List<jugador> j = dataContext.jugadors.Where(x => x.id_usuari == id_usuari).ToList();
                foreach (jugador jug in j)
                {
                    if (jug != null)
                    {
                        dataContext.jugadors.Remove(jug);
                    }
                }
                dataContext.SaveChanges();
            }
            catch { }
        }
    }
}