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
        public static DocumentoDato DocumentoADato(Documento doc)
        {
            if (doc is Libro libro)
            {
                return new LibroDato(libro.ISBN, libro.Titulo, libro.Autor, libro.Editorial, libro.Anio, libro.NSS);
            }
            else if (doc is AudioLibro audio)
            {
                return new AudiolibroDato(audio.ISBN, audio.Titulo, audio.Autor, audio.Editorial, audio.Anio, audio.NSS,
                                          audio.Formato, audio.Duracion);
            }
            return null;
        }

        public static Documento DatoADocumento(DocumentoDato dd)
        {
            if (dd is LibroDato ld)
            {
                return new Libro(ld.Id, ld.Titulo, ld.Autor, ld.Editorial, ld.Año, ld.NSS);
            }
            else if (dd is AudiolibroDato ad)
            {
                return new AudioLibro(ad.Id, ad.Titulo, ad.Autor, ad.Editorial, ad.Año, ad.NSS, ad.Formato, ad.Duracion);
            }
            return null;
        }
    }
}
