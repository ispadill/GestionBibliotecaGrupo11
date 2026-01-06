using ClassLibrary1;
using LogicaNegocio;
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
    public partial class FDevolucion : Form
    {
        private LNPersonalSala sala;
       

        public FDevolucion(LogicaNegocio.LNPersonalSala objetoLogica)
        {
            InitializeComponent();
            this.sala = objetoLogica;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamamos a la lógica para liberar el libro
                sala.DevolverEjemplar(txtIsbn.Text, txtCodigo.Text);

                MessageBox.Show("Libro devuelto correctamente. Ya está disponible para préstamo.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
