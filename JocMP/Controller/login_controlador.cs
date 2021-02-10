using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using View;

namespace Controller
{
    public class login_controlador
    {
        Login log = new Login();

        public Boolean primer = true;
        public void run()
        {
            Application.Run(log);
        }
        public void populate()
        {
            log.btini.Click += new EventHandler(IniciaSessio);
            log.btregis.Click += new EventHandler(Registra);
            log.textnom.KeyPress += txtLletra_KeyPress;
        }
        // limita a l'usuari a posar nomeas lletres
        private void txtLletra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Sols pots posar lletres", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        // comprova si l'usuari esta a la base de dades i et porta al menu.
        private void IniciaSessio(object sender, EventArgs e)
        {
            String nom = log.textnom.Text;
            String contra = log.textcontra.Text;
            contra = getHashSha256(contra);

            List<usuari> lu = new List<usuari>();
            try
            {
                lu = usuari_repositori.GetUsuarisNom(nom);
            }
            catch { }

            try
            {
                if (lu != null)
                {
                    foreach (usuari u in lu)
                    {
                        if (u.nom == nom)
                        {
                            if (u.contrasenya == contra)
                            {
                                int id = (int)u.id;
                                menu_controlador me = new menu_controlador();

                                log.Hide();
                                me.populate(nom, id);
                                me.run();
                            }
                            else
                            {
                                MessageBox.Show("La contrasenya és incorrecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hi ha cap usuari amb aquest nom!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error del web service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch { MessageBox.Show("Error del web service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
        //comproba que no hi hagin usuaris amb el mateix nombre d'usuari i si no hi ha registra a la base de dades l'usuari
        private void Registra(object sender, EventArgs e)
        {
            int n = 0;
            if (!log.textnom.Text.Equals("") && !log.textcontra.Text.Equals(""))
            {
                usuari u = new usuari();
                u.nom = log.textnom.Text;
                u.contrasenya = getHashSha256(log.textcontra.Text);

                List<usuari> llistau = new List<usuari>();
                try
                {
                    llistau = usuari_repositori.GetUsuarisNom(u.nom);
                }
                catch { }

                log.txtConfi.Visible = true;
                log.textconficontra.Visible = true;

                if (primer)
                {
                    primer = false;
                }
                else
                {
                    if (!log.textcontra.Text.Equals("") && !log.textconficontra.Text.Equals("") && !log.textnom.Text.Equals(""))
                    {
                        string confi = getHashSha256(log.textconficontra.Text);
                        if (confi == u.contrasenya)
                        {
                            if (llistau != null)
                            {
                                n = 0;
                                foreach (usuari us in llistau)
                                {
                                    if (us.nom.ToLower().Equals(u.nom.ToLower()))
                                    {
                                        MessageBox.Show("Ja existeix un usuari amb aquest nom!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        n = 0;
                                    }
                                    else
                                    {
                                        n++;
                                    }
                                }
                                if (n == llistau.Count)
                                {
                                    Inserta(u);
                                }
                            }
                            else
                            {
                                Inserta(u);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Les contrasenyes no coincideixen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tots els camps han de estar plens", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Per a inserir usuaris han de estar tots els camp plens ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // inserta l'usuari a la base de dades
        private void Inserta(usuari u)
        {
            try
            {
                usuari_repositori.InsertUsuari(u);
                MessageBox.Show("El usuari " + log.textnom.Text + " ha sigut inserit!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("El usuari no ha sigut inserit!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            log.txtConfi.Visible = false;
            log.textconficontra.Visible = false;
            log.textconficontra.Text = "";
        }

        public static string getHashSha256(string contra)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(contra);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

    }
}
