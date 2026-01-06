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
    public partial class FAltaDocumento : Form
    {
        private LogicaNegocio.LNPersonalAdquisiciones adq;

        public FAltaDocumento(LogicaNegocio.LNPersonalAdquisiciones objetoLogica)
        {
            InitializeComponent();
            this.adq = objetoLogica;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = txtIsbn.Text;
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string editorial = txtEditorial.Text;
                int anio = int.Parse(txtAnio.Text);

                if (cbTipo.Text == "Libro")
                {
                    adq.AltaLibro(isbn, titulo, autor, editorial, anio);
                }
                else if (cbTipo.Text == "Audiolibro")
                {
                    string formato = txtFormato.Text;
                    int duracion = int.Parse(txtDuracion.Text);

                    adq.AltaAudioLibro(isbn, titulo, autor, editorial, anio, formato, duracion);
                }

                MessageBox.Show("Documento guardado con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si seleccionas Audiolibro, mostramos los campos. Si no, los ocultamos.
            bool esAudio = (cbTipo.Text == "Audiolibro");

            txtFormato.Visible = esAudio;
            txtDuracion.Visible = esAudio;
            label6.Visible = esAudio; 
            label7.Visible = esAudio;
        }
    }
}
