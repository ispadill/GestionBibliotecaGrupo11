using ClassLibrary1;
using Persistencia.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class LNPersonalAdquisiciones : LNPersonalBiblioteca
    {
        private PersonalAdquisiciones pAdq;
        public LNPersonalAdquisiciones(PersonalAdquisiciones pAdq)
        {
            this.p = pAdq;
            this.pAdq = pAdq;
        }
        //PRE: -
        //POST: Se añade un nuevo objeto Libro a la base de datos vinculado al personal actual. Lanza excepción si el libro ya existe.
        public void AltaLibro(string isbn, string titulo, string autor, string editorial, int anio)
        {
            if(PersistenciaDocumento.READ(isbn) != null)
            {
                throw new Exception("El libro ya existe.");
            }
            Libro l = new Libro(isbn, titulo, autor, editorial, anio);
            PersistenciaDocumento.CREATE(l,pAdq.NSS);
        }
        //PRE: -
        //POST: Se añade un nuevo objeto AudioLibro a la base de datos. Lanza excepción si ya existe.
        public void AltaAudioLibro(string isbn, string titulo, string autor, string editorial, int anio, string formato, int duracion)
        {
            if (PersistenciaDocumento.READ(isbn) != null)
            {
                throw new Exception("El audiolibro ya existe.");
            }
            AudioLibro al = new AudioLibro(isbn, titulo, autor, editorial, anio, formato, duracion);
            PersistenciaDocumento.CREATE(al, pAdq.NSS);
        }
        //PRE: Debe existir un Documento (Libro o Audiolibro) registrado con ese isbn.
        //POST: Se añade un nuevo Ejemplar a la base de datos con estado Prestado = false
        public void AltaEjemplar(string isbn, string codigo)
        {
            Documento doc = PersistenciaDocumento.READ(isbn);
            if (doc==null)
            {
                throw new Exception("No existe el documento, primero debe darlo de alta");
            }
            Ejemplar ej = new Ejemplar(codigo, false, doc);
            PersistenciaEjemplar.CREATE(ej, pAdq.NSS);
        }
        //PRE: -
        //POST: El ejemplar es eliminado físicamente de la base de datos. Lanza excepción si el ejemplar no existe.
        public void BajaEjemplar(string isbn, string codigo)
        {
            Ejemplar ej = PersistenciaEjemplar.READ(isbn, codigo);
            if (ej == null) throw new Exception("El ejemplar no existe.");

            PersistenciaEjemplar.DELETE(ej);
        }
        //PRE: -
        //POST: Devuelve un entero representando la cantidad de ejemplares disponibles para ese ISBN.
        public int ConsultarDisponibilidad(string isbn)
        {
            List<Ejemplar> disponibles = PersistenciaEjemplar.READ_DISPONIBLES(isbn);
            return disponibles.Count;
        }

        //PRE: La tabla de préstamos debe contener datos para obtener un resultado válido.
        //POST: Devuelve un string indicando el ISBN más frecuente y su cantidad de préstamos. Si no hay datos, devuelve un mensaje informativo.
        public string ObtenerMasLeido()
        {
            var recuento = new Dictionary<string, int>();

            foreach (var p in Persistencia.BD.TablaPrestamo)
            {
                string isbn = "555"; 

                if (recuento.ContainsKey(isbn)) recuento[isbn]++;
                else recuento[isbn] = 1;
            }

            var max = recuento.OrderByDescending(x => x.Value).FirstOrDefault();

            if (max.Key != null)
                return $"El libro más leído es el ISBN: {max.Key} (Prestado {max.Value} veces)";

            return "No hay préstamos registrados todavía.";
        }

        



    }
}
