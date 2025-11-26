using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Ejemplar
    {
        private String codigo;
        private bool prestado;
        private Documento documento;

        public Ejemplar(string codigo, bool prestado, Documento documento)
        {
            this.codigo = codigo;
            this.prestado = prestado;
            this.documento = documento;
        }

        public String Codigo { get { return codigo; } set { codigo = value;  } }
        public bool Prestado { get { return prestado; } } 
        public Documento Documento { get { return documento; } set { documento = value; } }

        public void marcarPrestado(bool prestado)
        {
            this.prestado = prestado;
        }
    }
}
