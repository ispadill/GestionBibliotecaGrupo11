using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class AudioLibro : Documento
    {
        public const int DIAS_PRESTAMO = 10;

        private string formato;
        private int duracion;

        public AudioLibro(string isbn, string titulo, string autor, string editorial,
                          int anio, string formato, int duracion)
            : base(isbn, titulo, autor, editorial, anio)
        {
            this.formato = formato;
            this.duracion = duracion;
        }

        public string Formato { get { return formato; } set { formato = value; } }
        public int Duracion { get { return duracion; } set { duracion = value; } }
    }
}
