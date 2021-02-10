using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace Controller
{
    // creem les variables 
    public class menujoc_controlador
    {
        MenuJoc mj = new MenuJoc();

        string nomusu;
        int idusu;

        usuari u = new usuari();

        jugador_repositori jr = new jugador_repositori();

        // enseñem la vista
        public void run()
        {
            mj.Show();
        }

        // initzialitzem variable i cridem als metodes principals
        public void populate(string nom, int id)
        {
            nomusu = nom;
            idusu = id;

            u = usuari_repositori.GetUsuariName(nomusu);
            mj.btsur.Click += survival;
            mj.btraid.Click += raid;
            mj.btenrere.Click += enrere;
            mj.FormClosing += Tanca;

            plenarcombo();
        }
        // plena el combobox del menu amb els noms del jugadors de l'usuari que ha iniciat sessio
        private void plenarcombo()
        {
            List<jugador> lj = jugador_repositori.GetJugadorUsuariIdList(idusu);

            foreach (jugador j in lj)
            {
                mj.comboTriajuga.Items.Add(j.nom);
            }
            mj.comboTriajuga.SelectedIndex = 0;
        }
        // agafa les dades les jugador per a pasarles al controlador del survival 
        private void survival(object sender, EventArgs e)
        {
            String nom = mj.comboTriajuga.SelectedItem.ToString();

            List<jugador> lj = new List<jugador>();
            try
            {
                lj = jugador_repositori.GetJugadorUsuariIdList(idusu);
            }
            catch { }

            if (lj.Count > 0)
            {
                foreach (jugador j in lj)
                {
                    if (j.nom == nom)
                    {
                        int idpers = (int)(j.id_personatge);
                        int idarma = (int)(j.id_arma);
                        int idarmadura = (int)(j.id_armadura);
                        int idjug = (int)(j.id);
                        int nivelJug = (int)(j.nivell);
                        survival_controlador mc = new survival_controlador();

                        mj.Hide();
                        mc.populate(idusu, nomusu, idjug, nom, idpers, idarma, idarmadura, nivelJug);
                        mc.run();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hi ha hagut algun error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // agafa les dades les jugador per a pasarles al controlador de la raid 
        private void raid(object sender, EventArgs e)
        {
            String nom = mj.comboTriajuga.SelectedItem.ToString();

            List<jugador> lj = new List<jugador>();
            try
            {
                lj = jugador_repositori.GetJugadorUsuariIdList(idusu);
            }
            catch { }

            if (lj.Count > 0)
            {
                foreach (jugador j in lj)
                {
                    if (j.nom == nom)
                    {
                        int idpers = (int)(j.id_personatge);
                        int idarma = (int)(j.id_arma);
                        int idarmadura = (int)(j.id_armadura);
                        int idjug = (int)(j.id);
                        int nivelJug = (int)(j.nivell);
                        raid_controlador rc = new raid_controlador();

                        mj.Hide();
                        rc.populate(idusu, nomusu, idjug, nom, idpers, idarma, idarmadura, nivelJug);
                        rc.run();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hi ha hagut algun error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void enrere(object sender, EventArgs e)
        {
            menu_controlador mc = new menu_controlador();

            mj.Hide();
            mc.populate(nomusu, idusu);
            mc.run();
        }

        private void Tanca(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
