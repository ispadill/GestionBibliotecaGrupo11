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
    public partial class FBajaEjemplar : Form
    {
        private LogicaNegocio.LNPersonalAdquisiciones adq;

        public FBajaEjemplar(LogicaNegocio.LNPersonalAdquisiciones objetoLogica)
        {
            InitializeComponent();
            this.adq = objetoLogica;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                adq.BajaEjemplar(txtIsbn.Text, txtCodigoEjemplar.Text);

                MessageBox.Show("Ejemplar dado de baja.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FBajaEjemplar_Load(object sender, EventArgs e)
        {

        }
    }
}
