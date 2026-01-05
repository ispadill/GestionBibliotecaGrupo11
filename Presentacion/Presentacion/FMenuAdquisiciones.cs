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
    public partial class FMenuAdquisiciones : Form
    {
        private LNPersonalAdquisiciones adq;

        public FMenuAdquisiciones(LNPersonalAdquisiciones objetoLogica)
        {
            InitializeComponent();
            this.adq = objetoLogica;
        }

        private void FMenuAdquisiciones_Load(object sender, EventArgs e)
        {

        }

        private void btnAltaDocumento_Click(object sender, EventArgs e)
        {
            // FAltaDocumento ventana = new FAltaDocumento(this.adq);
            // ventana.ShowDialog();
            MessageBox.Show("Abriendo Alta de Documentos...");
        }

        private void btnAltaEjemplar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendo Alta de Ejemplares...");

        }

        private void btnBajaEjemplar_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FGestionUsuarios ventana = new FGestionUsuarios(this.adq);
            ventana.ShowDialog();
        }
    }
}
