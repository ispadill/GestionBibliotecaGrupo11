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
    public partial class FPrestamosAtrasados : Form
    {
        private LNPersonalSala sala;

        public FPrestamosAtrasados(LNPersonalSala objetoLogica)
        {
            InitializeComponent();
            this.sala = objetoLogica;
            CargarAtrasados();
        }

        private void CargarAtrasados()
        {
            lstAtrasados.Items.Clear();
            List<string> atrasados = sala.ConsultarPrestamosFueraDePlazo();

            if (atrasados.Count > 0)
            {
                foreach (var item in atrasados)
                {
                    lstAtrasados.Items.Add(item);
                }
            }
            else
            {
                lstAtrasados.Items.Add("No hay préstamos con retraso hoy.");
            }
        }

        private void lstAtrasados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}