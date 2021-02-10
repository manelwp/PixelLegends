using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using View.Properties;

namespace Controller
{
    // creem totes les variables utilitzades
    public class raid_controlador
    {
        Raid ra = new Raid();

        usuari u = new usuari();
        int idusu;
        string nomusu;

        monstre m = new monstre();
        arma ar = new arma();
        armadura ad = new armadura();
        jugador j = new jugador();
        Random random = new Random();

        int id_jugador;
        int id_arma;
        int id_armadura;
        int id_personatge;
        int vidaInicia;
        int contador = 0;

        public void run()
        {
            ra.Show();
        }

        // initzialitmez les variebles i cridem als metodes principals
        public void populate(int idus, string nomus, int idjug, string nom, int idpersona, int idarma, int idarmadura, int nivJug)
        {
            nomusu = nomus;
            idusu = idus;

            id_jugador = idjug;
            id_arma = idarma;
            id_armadura = idarmadura;
            id_personatge = idpersona;

            u = usuari_repositori.GetUsuariName(nomusu);
            ra.btsortir.Click += Sortir;
            ra.btnPotion.Click += Pocio;
            ra.btnAtacar.Click += atacnormal;
            ra.btneAtack.Click += atacespecial;
            ra.FormClosing += Tanca;

            apareixmonstre();
            carregajugador(idjug, idarma, idarmadura);
            vidaInicia = (int)j.vida;
        }
        // Metode que serveix per quan l'usuari fa un atac magic
        private void atacespecial(object sender, EventArgs e)
        {
            int vidamons = Convert.ToInt32(ra.txtvidamons.Text.ToString());
            vidamons = vidamons - ((int)j.atac_especial + (int)ar.dany_especial);
            int vidajug = Convert.ToInt32(ra.txtvidajug.Text.ToString());

            if (vidamons > 0)
            {
                ra.txtvidamons.Text = vidamons.ToString();

                int atmons = random.Next(2);

                if (atmons == 1)
                {
                    if ((int)m.atac > (int)ad.defensa)
                    {
                        vidajug = vidajug - ((int)m.atac - (int)ad.defensa);
                    }
                    else
                    {
                        vidajug = vidajug - 1;
                    }
                }
                else
                {
                    if ((int)m.atac_especial > (int)ad.defensa_especial)
                    {
                        vidajug = vidajug - ((int)m.atac_especial - (int)ad.defensa_especial);
                    }
                    else
                    {
                        vidajug = vidajug - 1;
                    }

                }

                ra.txtvidajug.Text = vidajug.ToString();
            }
            else
            {
                monstremort();
            }

            if (vidajug <= 0)
            {
                ra.txtvidajug.Text = (0).ToString();
                MessageBox.Show("has perdut");
                ra.btnAtacar.Visible = false;
                ra.btneAtack.Visible = false;
                ra.btnPotion.Visible = false;
            }
        }

        // Metode que serveix per quan l'usuari fa un atac fisic
        private void atacnormal(object sender, EventArgs e)
        {
            int vidamons = Convert.ToInt32(ra.txtvidamons.Text.ToString());
            vidamons = vidamons - ((int)j.atac + (int)ar.dany);
            int vidajug = Convert.ToInt32(ra.txtvidajug.Text.ToString());

            if (vidamons > 0)
            {
                ra.txtvidamons.Text = vidamons.ToString();

                int atmons = random.Next(2);

                if (atmons == 1)
                {
                    if ((int)m.atac > (int)ad.defensa)
                    {
                        vidajug = vidajug - ((int)m.atac - (int)ad.defensa);
                    }
                    else
                    {
                        vidajug = vidajug - 1;
                    }

                }
                else
                {
                    if ((int)m.atac_especial > (int)ad.defensa_especial)
                    {
                        vidajug = vidajug - ((int)m.atac_especial - (int)ad.defensa_especial);
                    }
                    else
                    {
                        vidajug = vidajug - 1;
                    }
                }

                ra.txtvidajug.Text = vidajug.ToString();
            }
            else
            {
                monstremort();
            }

            if (vidajug <= 0)
            {
                ra.txtvidajug.Text = (0).ToString();
                MessageBox.Show("has perdut");
                ra.btnAtacar.Visible = false;
                ra.btneAtack.Visible = false;
                ra.btnPotion.Visible = false;
            }
        }
        // metode per quan es pren el boto de la pocio i cura al personatge

        private void Pocio(object sender, EventArgs e)
        {
            if (contador < 4)
            {
                ra.txtvidajug.Text = vidaInicia.ToString();
                contador++;
            }
            else
            {
                MessageBox.Show("Sols 5 pocions per monstre");
            }
        }

        //metode que aplica les imatges de armes i armadures al jugador

        public void carregajugador(int idjug, int arma, int armadura)
        {
            try
            {
                j = jugador_repositori.GetJugadorId(idjug);

                ResourceManager rm = Resources.ResourceManager;
                Bitmap arm = (Bitmap)rm.GetObject("arma" + j.id_arma);
                Bitmap armd = (Bitmap)rm.GetObject("armadura" + j.id_armadura);
                Bitmap cor = (Bitmap)rm.GetObject("cor");

                ra.pbArma.Image = arm;
                ra.pbPersonaje.Image = armd;
                ra.pctcorjug.Image = cor;
                ra.txtvidajug.Text = j.vida.ToString();

                ar = arma_repositori.GetArmaId((int)j.id_arma);
                ad = armadura_repositori.GetArmaduraId((int)j.id_armadura);
            }
            catch { }
        }

        //metode que fa que aparegui el monstre amb la id corresponent

        private void apareixmonstre()
        {
            try
            {
                m = monstre_repositori.GetMonstreId(16);
                ra.lblnommons.Text = m.nom;
                ra.txtvidamons.Text = m.vida.ToString();

                ResourceManager rm = Resources.ResourceManager;
                Bitmap mons = (Bitmap)rm.GetObject("monstre" + m.id);
                ra.pbMonster.Image = mons;

                Bitmap cor = (Bitmap)rm.GetObject("cor");
                ra.pctcormons.Image = cor;
            }
            catch { }
        }
        // metode que desbloqueja el personatge secret quan el monstre mor
        private void monstremort()
        {
            ra.txtvidamons.Text = (0).ToString();

            u.secret = 1;
            try
            {
                usuari_repositori.UpdateUsuari(u.id, u);
            }
            catch { }

            MessageBox.Show("El teu usuari ha desbloquejat el Bartolo com a personatge.");
            ra.btnAtacar.Visible = false;
            ra.btneAtack.Visible = false;
            ra.btnPotion.Visible = false;

            m.vida = 50000;
            ra.txtvidamons.Text = m.vida.ToString();
            try
            {
                monstre_repositori.UpdateMonstre(m.id, m);
            }
            catch { }
        }

        // metode per sortir

        private void Sortir(object sender, EventArgs e)
        {
            m.vida = Convert.ToInt32(ra.txtvidamons.Text.ToString());
            try
            {
                monstre_repositori.UpdateMonstre(m.id, m);
            }
            catch { }

            menujoc_controlador mc = new menujoc_controlador();

            ra.Hide();
            mc.populate(nomusu, idusu);
            mc.run();
        }

        private void Tanca(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
