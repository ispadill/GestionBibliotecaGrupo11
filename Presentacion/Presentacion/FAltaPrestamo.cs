using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using LogicaNegocio;

namespace Presentacion
{
    public partial class FAltaPrestamo : Form
    {
        private LNPersonalSala sala;
        private List<Ejemplar> listaParaPrestamo = new List<Ejemplar>();


        public FAltaPrestamo(LogicaNegocio.LNPersonalSala objetoLogica)
        {
            InitializeComponent();
            this.sala = objetoLogica;
        }

        private void txtDniUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoEjemplar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstEjemplares_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var ejemplares = sala.BuscarEjemplaresDisponibles(txtIsbn.Text);
            var ej = ejemplares.Find(x => x.Codigo == txtCodigoEjemplar.Text);

            if (ej != null)
            {
                listaParaPrestamo.Add(ej);
                lstEjemplares.Items.Add(ej.Documento.Titulo + " (Cod: " + ej.Codigo + ")");
            }
            else
            {
                MessageBox.Show("Ejemplar no encontrado o no disponible.");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = new Random().Next(1, 10000);

                sala.AltaPrestamo(id, txtDniUsuario.Text, listaParaPrestamo);

                MessageBox.Show("¡Préstamo realizado con éxito!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FAltaPrestamo_Load(object sender, EventArgs e)
        {

        }
    }
}
