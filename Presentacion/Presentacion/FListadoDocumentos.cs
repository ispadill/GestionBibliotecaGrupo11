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
    public partial class FListadoDocumentos : Form
    {
        public FListadoDocumentos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            lstDocumentos.Items.Clear();

            foreach (var doc in Persistencia.BD.TablaDocumento)
            {
                string linea = $"{doc.Id} | {doc.Titulo} - {doc.Autor}";
                lstDocumentos.Items.Add(linea);
            }
        }
        private void lstDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
