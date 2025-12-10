using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Libro : Documento
    {
        public const int DIAS_PRESTAMO = 15;

        public Libro(string isbn, string titulo, string autor, string editorial, int anio)
            : base(isbn, titulo, autor, editorial, anio)
        {
        }
    }
}
