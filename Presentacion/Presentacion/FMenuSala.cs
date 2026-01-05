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
    public partial class FMenuSala : Form
    {
        private LNPersonalSala sala;

        // Para q el constructor reciba la lógica
        public FMenuSala(LNPersonalSala objetoLogica)
        {
            InitializeComponent();
            this.sala = objetoLogica;
        }

        private void FMenuSala_Load(object sender, EventArgs e)
        {

        }
    }
}
