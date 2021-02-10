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
    public class mirarjugador_controlador
    {
        ResourceManager rm = Resources.ResourceManager;
        MirarJugadors mj = new MirarJugadors();
        jugador_repositori jr = new jugador_repositori();

        String nomusu;
        int idusu;

        personatge p = new personatge();
        arma a = new arma();
        armadura ad = new armadura();

        public void run()
        {
            mj.Show();
        }

        public void populate(string nom, int id)
        {
            nomusu = nom;
            idusu = id;

            mj.FormClosing += Tanca;
            mj.dtJug.DataSource = jr.GetAllJugador();
            mj.btcerca.Click += BtCercaClick;
            mj.btenrere.Click += BtEnrereClick;
            mj.dtJug.SelectionChanged += dtjug_SelectionChanged;

        }

        private void dtjug_SelectionChanged(object sender, EventArgs e)
        {//mitjançant aquest mètode podem anar selecionant els diferents jugadors i les imatges es van modificant depenent del personatge, arma 
            //object armadura que tingui el jugador
            try
            {
                if (mj.dtJug.SelectedRows.Count > 0)
                {
                    DataGridViewCellCollection dc = mj.dtJug.SelectedRows[0].Cells;
                    mj.dtJug.Columns["id_personatge"].Visible = false;
                    mj.dtJug.Columns["id_arma"].Visible = false;
                    mj.dtJug.Columns["id_armadura"].Visible = false;

                    p = personatge_repositori.GetPersonatgeId(Convert.ToInt32(mj.dtJug.CurrentRow.Cells[9].Value.ToString()));
                    a = arma_repositori.GetArmaId(Convert.ToInt32(mj.dtJug.CurrentRow.Cells[10].Value.ToString()));
                    ad = armadura_repositori.GetArmaduraId(Convert.ToInt32(mj.dtJug.CurrentRow.Cells[11].Value.ToString()));

                    mj.lblnom.Text = p.nom;
                    Bitmap arm = (Bitmap)rm.GetObject("arma" + a.id);
                    mj.pctarma.Image = arm;
                    Bitmap amd = (Bitmap)rm.GetObject("armadura" + ad.id);
                    mj.pctarmadura.Image = amd;
                }
            }
            catch
            {
                MessageBox.Show("Error al selecionar a la taula jugadors");
            }
        }

        private void BtEnrereClick(object sender, EventArgs e)
        {
            menu_controlador me = new menu_controlador();

            mj.Hide();
            me.populate(nomusu, idusu);
            me.run();
        }

        private void BtCercaClick(object sender, EventArgs e)
        {//aquest mètode busca els jugadors segons el radio button i els que s'ha introduït en el textbox
            try
            {
                if (mj.rbidjug.Checked && mj.txtcerca.Text.Length > 0)
                {
                    int id = Convert.ToInt32(mj.txtcerca.Text.ToString());
                    mj.dtJug.DataSource = jugador_repositori.GetJugadorIdList(id);
                }
                else if (mj.rbnom.Checked && mj.txtcerca.Text.Length > 0)
                {
                    string nom = mj.txtcerca.Text.ToString();
                    mj.dtJug.DataSource = jr.GetJugadorNameList(nom);
                }
                else if (mj.rbidusr.Checked && mj.txtcerca.Text.Length > 0)
                {
                    int id = Convert.ToInt32(mj.txtcerca.Text.ToString());
                    mj.dtJug.DataSource = jugador_repositori.GetJugadorUsuariIdList(id);
                }
                else if (mj.rbtots.Checked && mj.txtcerca.Text.Length > 0)
                {
                    mj.dtJug.DataSource = jr.GetAllJugador();
                }
            }
            catch { MessageBox.Show("Error al filtrar."); }
        }

        private void Tanca(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
