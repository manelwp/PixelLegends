using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using View.Properties;

namespace Controller
{
    public class survival_controlador
    {
        Survival su = new Survival();
        monstre m = new monstre();
        monstre mInicial = new monstre();
        jugador j = new jugador();
        arma a = new arma();
        armadura ad = new armadura();

        Random random = new Random();

        int nummonstre = 0;
        int id_jugador;
        int id_arma;
        int id_armadura;
        int id_personatge;
        int idusu;
        int vidaInicia;
        int contador = 0;
        string nomusu;

        public void run()
        {
            su.Show();
        }

        public void populate(int id, string nomus, int idjug, string nom, int idpersona, int idarma, int idarmadura, int nivJug)
        {
            j.nivell = 1;
            idusu = id;
            nomusu = nomus;
            id_jugador = idjug;
            id_arma = idarma;
            id_armadura = idarmadura;
            id_personatge = idpersona;


            cargaimagen(idjug, idarma, idarmadura);

            su.btnAtacar.Click += new EventHandler(ataqueNormal);
            su.btneAtack.Click += new EventHandler(ataqueSpecial);
            su.btcanvi.Click += Canvi;
            su.btmante.Click += Mante;
            su.btsortir.Click += Sortir;
            su.btnNewGame.Click += NewGame;
            su.btnPotion.Click += PotionOn;

            vidaInicia = (int)j.vida;

            su.FormClosing += Tanca;
            apareixmonstre();
        }

        private void PotionOn(object sender, EventArgs e)
        {
            //serveix per pujar la vida del jugador
            if (contador < 1)
            {
                su.txtvidajug.Text = vidaInicia.ToString();
                contador++;
            }
            else
            {
                MessageBox.Show("Sols 1 poció per monstre");
            }
        }

        private void NewGame(object sender, EventArgs e)
        {
            j.nivell = j.nivell + 1;
            apareixmonstre();

            su.pbyouwin.Visible = false;
            su.pbfelis.Visible = false;
            su.btnAtacar.Visible = true;
            su.btneAtack.Visible = true;
            su.btnNewGame.Visible = false;
        }

        private void Sortir(object sender, EventArgs e)
        {
            menujoc_controlador mc = new menujoc_controlador();

            su.Hide();
            mc.populate(nomusu, idusu);
            mc.run();
        }

        private void Mante(object sender, EventArgs e)
        {
            su.pbyouwin.Visible = false;
            su.pbfelis.Visible = false;
            su.pctcofre.Visible = false;
            su.pctnouitem.Visible = false;
            su.btcanvi.Visible = false;
            su.btmante.Visible = false;
            su.lblnormalnou.Visible = false;
            su.lblespecialnou.Visible = false;
            cargaimagen(id_jugador, id_arma, ad.id);

            apareixmonstre();
        }

        private void Canvi(object sender, EventArgs e)
        {
            //actualitza el jugador amb l'arma o armadura corresponent si a fet clic al botó canvi
            su.pbyouwin.Visible = false;
            su.pbfelis.Visible = false;
            su.pctcofre.Visible = false;
            su.pctnouitem.Visible = false;
            if (a.nom != null)
            {
                j.id_arma = a.id;
                try
                {
                    jugador_repositori.UpdateJugador(id_jugador, j);
                    cargaimagen(id_jugador, a.id, id_armadura);
                }
                catch { }
            }
            else if (ad.nom != null)
            {
                j.id_armadura = ad.id;
                try
                {
                    jugador_repositori.UpdateJugador(id_jugador, j);
                    cargaimagen(id_jugador, id_arma, ad.id);
                }
                catch { }
            }
            su.btcanvi.Visible = false;
            su.btmante.Visible = false;
            su.lblnormalnou.Visible = false;
            su.lblespecialnou.Visible = false;

            apareixmonstre();
        }

        private void apareixmonstre()
        {//obté un monstre
            contador = 0;
            nummonstre++;
            try
            {
                m = monstre_repositori.GetMonstreId(nummonstre);
            }
            catch { }
            //incrementa el nivell del monstre una vegada pasat el joc per primer cop.
            if (j.nivell > 1)
            {
                m.vida = m.vida + 50;
                m.defensa = m.defensa + 5;
                m.atac = m.atac + 5;
                m.defensa_especial = m.defensa_especial + 5;
                m.atac_especial = m.atac_especial + 5;

            }
            su.txtnommons.Text = m.nom;
            su.txtvidamons.Text = m.vida.ToString();

            try
            {
                //modifica la imatge del monstre al monstre actual i obté l'arma i l'armadura del jugador
                ResourceManager rm = Resources.ResourceManager;
                Bitmap mons = (Bitmap)rm.GetObject("monstre" + nummonstre);
                su.pbMonster.Image = mons;

                Bitmap cor = (Bitmap)rm.GetObject("cor");
                su.pctcormons.Image = cor;

                arma arma = new arma();
                armadura armadura = new armadura();

                arma = arma_repositori.GetArmaId((int)j.id_arma);
                su.lblatac.Text = arma.dany.ToString();
                su.lblatacespecial.Text = arma.dany_especial.ToString();

                armadura = armadura_repositori.GetArmaduraId((int)j.id_armadura);
                su.lbldefensa.Text = armadura.defensa.ToString();
                su.lbldefensaespecial.Text = armadura.defensa_especial.ToString();
            }
            catch { }
        }

        private void ataqueSpecial(object sender, EventArgs e)
        {
            //baixa la vida del monstre utilitzant l'atac especial del jugador, més el dany especial de l'arma
            int vidamons = Convert.ToInt32(su.txtvidamons.Text.ToString());
            vidamons = vidamons - ((int)j.atac_especial + (int)a.dany_especial);
            int vidajug = Convert.ToInt32(su.txtvidajug.Text.ToString());

            if (vidamons > 0)
            {
                su.txtvidamons.Text = vidamons.ToString();

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

                su.txtvidajug.Text = vidajug.ToString();
            }
            else
            {
                monstremort();
            }

            if (vidajug <= 0)
            {
                su.txtvidajug.Text = (0).ToString();
                MessageBox.Show("has perdut");
                su.btnNewGame.Visible = false;
                su.btnPotion.Visible = false;
                su.btcanvi.Visible = false;
                su.btmante.Visible = false;
                su.btneAtack.Visible = false;
                su.btnAtacar.Visible = false;
            }
        }

        private void monstremort()
        {//asigna el monstre a 0 quan es 15 per tornar a començar el joc.
            if (nummonstre == 15)
            {
                nummonstre = 0;
                su.pbyouwin.Visible = true;
                su.pbfelis.Visible = true;
                su.btnAtacar.Visible = false;
                su.btneAtack.Visible = false;
                su.btnNewGame.Visible = true;
            }
            else
            {
                //asgina la vida del monstre a 0 i fa un random del premi. Si és 0 es armadura sinó arma. 
                ResourceManager rm = Resources.ResourceManager;

                su.pctcofre.Visible = true;
                su.pctnouitem.Visible = true;
                su.btcanvi.Visible = true;
                su.btmante.Visible = true;
                su.pctcofre.Visible = true;

                su.txtvidamons.Text = (0).ToString();

                a = new arma();
                ad = new armadura();

                int ra = random.Next(2);

                int numarma = 0;
                int numarmadura = 0;
                //fa un random entre les armes i armadures del personatge
                if (id_personatge == 1)
                {//guerrer
                    numarma = random.Next(20) + 1;
                    numarmadura = random.Next(12) + 1;
                }
                else if (id_personatge == 2)
                {//mag
                    numarma = random.Next(21, 36);
                    numarmadura = random.Next(13, 22);
                }
                else if (id_personatge == 3)
                {//ranger
                    numarma = random.Next(36, 52);
                    numarmadura = random.Next(22, 33);
                }
                else if (id_personatge == 4)
                {
                    numarma = 52;
                    numarmadura = 33;
                }
                //utilitza el random esmentat anteriorment i tria si és arma o be armadura
                if (ra == 1)
                {
                    try
                    {//obté l'arma i modifica els diferents textbox i la imatge
                        a = arma_repositori.GetArmaId(numarma);
                        Bitmap arm = (Bitmap)rm.GetObject("arma" + numarma);
                        su.pctnouitem.Image = arm;
                        su.lblnormalnou.Text = a.dany.ToString();
                        su.lblespecialnou.Text = a.dany_especial.ToString();
                    }
                    catch { }
                }
                else
                {
                    try
                    {//obté l'armadura i modifica els diferents textbox i la imatge
                        ad = armadura_repositori.GetArmaduraId(numarmadura);
                        Bitmap armd = (Bitmap)rm.GetObject("armadura" + numarmadura);
                        su.pctnouitem.Image = armd;
                        su.lblnormalnou.Text = ad.defensa.ToString();
                        su.lblespecialnou.Text = ad.defensa_especial.ToString();
                    }
                    catch { }
                }
                su.lblnormalnou.Visible = true;
                su.lblespecialnou.Visible = true;
            }
        }

        private void ataqueNormal(object sender, EventArgs e)
        {
            //baixa la vida del monstre utilitzant l'atac del jugador, més el dany de l'arma
            int vidamons = Convert.ToInt32(su.txtvidamons.Text.ToString());
            vidamons = vidamons - ((int)j.atac + (int)a.dany);
            int vidajug = Convert.ToInt32(su.txtvidajug.Text.ToString());

            if (vidamons > 0)
            {
                su.txtvidamons.Text = vidamons.ToString();

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

                su.txtvidajug.Text = vidajug.ToString();
            }
            else
            {
                monstremort();
            }

            if (vidajug <= 0)
            {
                su.txtvidajug.Text = (0).ToString();
                MessageBox.Show("has perdut");
                su.btnNewGame.Visible = false;
                su.btnPotion.Visible = false;
                su.btcanvi.Visible = false;
                su.btmante.Visible = false;
                su.btneAtack.Visible = false;
                su.btnAtacar.Visible = false;
            }
        }

        public void cargaimagen(int idjug, int arma, int armadura)
        {
            try
            {//rep el jugador
                j = jugador_repositori.GetJugadorId(idjug);

                //carrega la imatge del jugador i de les armes/armadures que té el jugador i també les obté asignant-les a objectes

                ResourceManager rm = Resources.ResourceManager;
                Bitmap arm = (Bitmap)rm.GetObject("arma" + j.id_arma);
                Bitmap armd = (Bitmap)rm.GetObject("armadura" + j.id_armadura);
                Bitmap cor = (Bitmap)rm.GetObject("cor");

                su.pbArma.Image = arm;
                su.pbPersonaje.Image = armd;
                su.pctcorjug.Image = cor;
                su.txtvidajug.Text = j.vida.ToString();

                a = arma_repositori.GetArmaId((int)j.id_arma);
                ad = armadura_repositori.GetArmaduraId((int)j.id_armadura);
            }
            catch { }
        }

        private void Tanca(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
