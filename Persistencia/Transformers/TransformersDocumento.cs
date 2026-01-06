using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Persistencia.Datos;

namespace Persistencia.Transformers
{
    internal static class TransformersDocumento
    {
        //PRE: doc no es nulo.
        //POST: Devuelve el EjemplarDato correspondiente al Documento doc.
        public static DocumentoDato DocumentoADato(Documento doc)
        {
            if (doc is Libro libro)
            {
                return new LibroDato(libro.ISBN, libro.Titulo, libro.Autor, libro.Editorial, libro.Anio, "");
            }
            else if (doc is AudioLibro audio)
            {
                return new AudiolibroDato(audio.ISBN, audio.Titulo, audio.Autor, audio.Editorial, audio.Anio, "", audio.Formato, audio.Duracion);
            }
            return null;
        }
        //PRE: dd no es nulo.
        //POST: Devuelve una instancia completa de Documento.
        public static Documento DatoADocumento(DocumentoDato dd)
        {
            if (dd is LibroDato ld)
            {
                return new Libro(ld.Id, ld.Titulo, ld.Autor, ld.Editorial, ld.Año);
            }
            else if (dd is AudiolibroDato ad)
            {
                return new AudioLibro(ad.Id, ad.Titulo, ad.Autor, ad.Editorial, ad.Año, ad.Formato, ad.Duracion);
            }
            return null;
        }
    }
}
