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
    public class menu_controlador
    {
        MenuV me = new MenuV();

        string nomusu;
        int idusu;

        public void run()
        {
            me.Show();
        }

        public void populate(string nom, int id)
        {
            me.btcrearjug.Click += CrearJugador;
            me.btJugMenu.Click += Jocs;
            me.btMirJug.Click += MirarJugador;
            me.FormClosing += Tanca;

            nomusu = nom;
            idusu = id;

            plenarcombo();
        }
        private void plenarcombo()
        {//obté tots els jugadors del usuari i els posa en un combobox
            List<jugador> lj = jugador_repositori.GetJugadorUsuariIdList(idusu);

            if (lj.Count == 0)
            {
                me.btJugMenu.Enabled = false;
            }
        }

        private void MirarJugador(object sender, EventArgs e)
        {
            mirarjugador_controlador mj = new mirarjugador_controlador();

            me.Hide();
            mj.populate(nomusu, idusu);
            mj.run();
        }

        private void Jocs(object sender, EventArgs e)
        {
            menujoc_controlador mj = new menujoc_controlador();

            me.Hide();
            mj.populate(nomusu, idusu);
            mj.run();
        }

        private void CrearJugador(object sender, EventArgs e)
        {
            crearjugador_controlador cj = new crearjugador_controlador();

            me.Hide();
            cj.populate(nomusu, idusu);
            cj.run();
        }

        private void Tanca(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
