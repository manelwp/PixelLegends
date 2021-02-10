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
    public class crearjugador_controlador
    {
        CrearJugador cj = new CrearJugador();

        string nomusu;
        int idusu;

        usuari u = new usuari();

        public void run()
        {
            cj.Show();
        }

        public void populate(string nom, int id)
        {
            nomusu = nom;
            idusu = id;
            //obté els usuari
            try
            {
                u = usuari_repositori.GetUsuariName(nomusu);
            }
            catch { }

            secret();
            cj.btinsereix.Click += insereixjugador;
            cj.btenre.Click += enrere;
            cj.FormClosing += Tanca;
        }

        private void secret()
        {//comprova si el usuari té secret(ha desbloquejat el personatge secret)
            if (u.secret == 1)
            {
                cj.rbbar.Enabled = true;
            }
        }

        private void enrere(object sender, EventArgs e)
        {
            menu_controlador me = new menu_controlador();

            cj.Hide();
            me.populate(nomusu, idusu);
            me.run();
        }

        private void insereixjugador(object sender, EventArgs e)
        {//comprova que no hi hagui cap jugador amb un nom semblant i l'insereix depenguent del radio button de personatges.
            if (!cj.tbnom.Text.Equals("") && !cj.tbnom.Text.Equals(null))
            {
                string nomjug = cj.tbnom.Text;
                jugador ju = new jugador();
                personatge p = new personatge();
                try
                {
                    ju = jugador_repositori.GetJugadorName(nomjug);
                }
                catch { }
                //insereix el jugador i comprova que hi hagui un radio button selecionat
                if (ju == null)
                {
                    if (!cj.rbguer.Checked && !cj.rbran.Checked && !cj.rbmag.Checked && !cj.rbbar.Checked)
                    {
                        MessageBox.Show("Seleciona un personatge");
                    }
                    else if (cj.rbguer.Checked)
                    {
                        Console.WriteLine("Guerrer");
                        p = personatge_repositori.GetPersonatgeId(1);
                        insjug(p, nomjug, 1, 1);
                    }
                    else if (cj.rbran.Checked)
                    {
                        Console.WriteLine("Ranger");
                        p = personatge_repositori.GetPersonatgeId(3);
                        insjug(p, nomjug, 36, 22);
                    }
                    else if (cj.rbmag.Checked)
                    {
                        Console.WriteLine("Mag");
                        p = personatge_repositori.GetPersonatgeId(2);
                        insjug(p, nomjug, 21, 13);
                    }
                    else if (cj.rbbar.Checked)
                    {
                        Console.WriteLine("Bartolo");
                        p = personatge_repositori.GetPersonatgeId(4);
                        insjug(p, nomjug, 52, 33);
                    }
                }
                else
                {
                    MessageBox.Show("Ja existeix un jugador amb aquest nom");
                }
            }
            else
            {
                MessageBox.Show("Introdueix un nom pel teu jugador");
            }
        }

        public void insjug(personatge per, string nom, int idarma, int idarmadura)
        {//insereix el jugador
            jugador jug = new jugador();
            jug.id_usuari = u.id;
            jug.nom = nom;
            jug.vida = per.vida;
            jug.id_personatge = per.id;
            jug.atac = per.atac;
            jug.atac_especial = per.atac_especial;
            jug.defensa = per.defensa;
            jug.defensa_especial = per.defensa_especial;
            jug.nivell = 1;
            jug.id_arma = idarma;
            jug.id_armadura = idarmadura;

            try
            {
                jugador_repositori.InsertJugador(jug);
                MessageBox.Show("El jugador " + nom + " ha sigut inserit!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("el jugador no ha sigut inserit", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tanca(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
