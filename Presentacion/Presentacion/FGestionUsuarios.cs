using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FGestionUsuarios : Form
    {
        private LogicaNegocio.LNPersonalBiblioteca logica;
        public FGestionUsuarios(LogicaNegocio.LNPersonalBiblioteca objetoLogica)
        {
            InitializeComponent(); 
            this.logica = objetoLogica;
            ActualizarLista();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FGestionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                logica.AltaUsuario(txtDni.Text, txtNombre.Text);

                MessageBox.Show("Usuario " + txtNombre.Text + " creado correctamente.");
                ActualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ActualizarLista()
        {
            lstUsuarios.Items.Clear();
            var usuarios = logica.ListarUsuarios();

            foreach (var u in usuarios)
            {
                lstUsuarios.Items.Add(u.Dni + " - " + u.Nombre);
            }
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
               
                string seleccionado = lstUsuarios.SelectedItem?.ToString();
                if (seleccionado == null) return;

                string dni = seleccionado.Split('-')[0].Trim();

                logica.BajaUsuario(dni);
                MessageBox.Show("Usuario eliminado.");
                ActualizarLista();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
