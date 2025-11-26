using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Documento
    {
        private String isbn;
        private String titulo;
        private String autor;
        private String editorial;
        private int anio;


        public Documento(string isbn, string titulo, string autor, string editorial, int anio, List<Ejemplar> ejemplares)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.anio = anio;
            this.ejemplares = ejemplares;
        }

        public String ISBN { get { return isbn; } }
        public String Titulo { get { return titulo; } }
        public String Autor { get { return autor; } }
        public String Editorial { get { return editorial; } }
        public int Anio { get { return anio; } }
        public List<Ejemplar > Ejemplares { get { return ejemplares; } }

        public 
    }
}
