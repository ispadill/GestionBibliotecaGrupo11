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
    public partial class FMenuSala : Form
    {
        private LNPersonalSala sala;

        // Constructor para recibir el objeto de lógica
        public FMenuSala(LNPersonalSala objetoLogica)
        {
            InitializeComponent();
            this.sala = objetoLogica;
        }

        public FMenuSala() {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            FAltaPrestamo ventana = new FAltaPrestamo(this.sala);
            ventana.ShowDialog();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendo Devoluciones...");
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FGestionUsuarios ventana = new FGestionUsuarios(this.sala);
            ventana.ShowDialog();
        }

        private void FMenuSala_Load(object sender, EventArgs e)
        {

        }
    }
}
