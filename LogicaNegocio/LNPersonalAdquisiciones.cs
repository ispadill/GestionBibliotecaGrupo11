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
        public void AltaLibro(string isbn, string titulo, string autor, string editorial, int anio)
        {
            if(PersistenciaDocumento.READ(isbn) != null)
            {
                throw new Exception("El libro ya existe.");
            }
            Libro l = new Libro(isbn, titulo, autor, editorial, anio);
            PersistenciaDocumento.CREATE(l,pAdq.NSS);
        }
        public void AltaAudioLibro(string isbn, string titulo, string autor, string editorial, int anio, string formato, int duracion)
        {
            if (PersistenciaDocumento.READ(isbn) != null)
            {
                throw new Exception("El audiolibro ya existe.");
            }
            AudioLibro al = new AudioLibro(isbn, titulo, autor, editorial, anio, formato, duracion);
            PersistenciaDocumento.CREATE(al, pAdq.NSS);
        }
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

        public void BajaEjemplar(string isbn, string codigo)
        {
            Ejemplar ej = PersistenciaEjemplar.READ(isbn, codigo);
            if (ej == null) throw new Exception("El ejemplar no existe.");

            // En una baja lógica, podrías borrarlo de la tabla activa o marcarlo como inactivo
            // Usamos el DELETE de tu persistencia
            PersistenciaEjemplar.DELETE(ej);
        }
        public int ConsultarDisponibilidad(string isbn)
        {
            List<Ejemplar> disponibles = PersistenciaEjemplar.READ_DISPONIBLES(isbn);
            return disponibles.Count;
        }




    }
}
