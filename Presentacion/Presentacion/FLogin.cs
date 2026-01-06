using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace Presentacion
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }
         
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var objetoLogica = LNPersonalBiblioteca.IniciarSesion(txtUsuario.Text, txtPassword.Text);


                if (objetoLogica == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    return;
                }

                if (objetoLogica is LNPersonalSala lnSala)
                {
                    FMenuSala menu = new FMenuSala(lnSala);
                    menu.FormClosed += (s, args) => this.Show();
                    menu.Show();
                    this.Hide();
                }
                else if (objetoLogica is LNPersonalAdquisiciones lnAdq)
                {
                    FMenuAdquisiciones menu = new FMenuAdquisiciones(lnAdq);
                    menu.Show();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
