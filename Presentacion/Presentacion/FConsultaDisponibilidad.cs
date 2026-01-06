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
    public partial class FConsultaDisponibilidad : Form
    {
        private LogicaNegocio.LNPersonalAdquisiciones adq;

        public FConsultaDisponibilidad(LogicaNegocio.LNPersonalAdquisiciones objetoLogica)
        {
            InitializeComponent();
            this.adq = objetoLogica;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Usamos el método de la lógica
            int cantidad = adq.ConsultarDisponibilidad(txtIsbn.Text);

            if (cantidad > 0)
                lblResultado.Text = "Hay " + cantidad + " ejemplares libres.";
            else
                lblResultado.Text = "No hay ejemplares disponibles ahora.";
        }
    }
}
