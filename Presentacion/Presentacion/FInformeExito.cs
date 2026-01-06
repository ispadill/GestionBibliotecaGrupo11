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
    public partial class FInformeExito : Form
    {
        public FInformeExito(LNPersonalAdquisiciones objetoLogica)
        {
            InitializeComponent();
            lblResultado.Text = objetoLogica.ObtenerMasLeido();
        }

        private void FInformeExito_Load(object sender, EventArgs e)
        {

        }
    }
}
