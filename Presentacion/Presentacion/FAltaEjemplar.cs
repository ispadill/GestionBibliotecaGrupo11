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
    public partial class FAltaEjemplar : Form
    {
        private LogicaNegocio.LNPersonalAdquisiciones adq;

        public FAltaEjemplar(LogicaNegocio.LNPersonalAdquisiciones objetoLogica)
        {
            InitializeComponent();
            this.adq = objetoLogica;
        }
        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                adq.AltaEjemplar(txtIsbn.Text, txtCodigoEjemplar.Text);

                MessageBox.Show("Ejemplar registrado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
