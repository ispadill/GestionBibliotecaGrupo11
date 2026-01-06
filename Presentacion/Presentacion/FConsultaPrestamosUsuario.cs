using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LogicaNegocio; 

namespace Presentacion
{
    public partial class FConsultaPrestamosUsuario : Form
    {
        private LNPersonalSala sala;

        public FConsultaPrestamosUsuario(LNPersonalSala objetoLogica)
        {
            InitializeComponent();
            this.sala = objetoLogica;
        }

        public FConsultaPrestamosUsuario() { InitializeComponent(); }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                lstPrestamos.Items.Clear();

                var resultados = sala.ConsultarPrestamosActivos(txtDni.Text);

                if (resultados.Count > 0)
                {
                    foreach (var r in resultados)
                    {
                        lstPrestamos.Items.Add(r);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no tiene préstamos activos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FConsultaPrestamosUsuario_Load(object sender, EventArgs e) { }
    }
}