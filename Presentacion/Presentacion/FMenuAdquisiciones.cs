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
            FAltaDocumento ventana = new FAltaDocumento(this.adq);
            ventana.ShowDialog();
        }

        private void btnAltaEjemplar_Click(object sender, EventArgs e)
        {
            new FAltaEjemplar(this.adq).ShowDialog();

        }

        private void btnBajaEjemplar_Click(object sender, EventArgs e)
        {
            new FBajaEjemplar(this.adq).ShowDialog();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FGestionUsuarios ventana = new FGestionUsuarios(this.adq);
            ventana.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            new FConsultaDisponibilidad(this.adq).ShowDialog();
        }

        private void btnVerCatalogo_Click(object sender, EventArgs e)
        {
            FListadoDocumentos ventana = new FListadoDocumentos();
            ventana.ShowDialog();
        }
    }
}
