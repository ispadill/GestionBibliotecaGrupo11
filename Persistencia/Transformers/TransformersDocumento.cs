using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio.Libro;

namespace Persistencia.Transformers
{
    internal static class TransformersDocumento
    {
        public static DocumentoDato DocumentoADato(Documento doc)
        {
            if (doc is Libro libro)
            {
                return new LibroDato(libro.ISBN, libro.Titulo, libro.Autor, libro.Editorial, libro.Año, libro.NSS);
            }
            else if (doc is AudioLibro audio)
            {
                return new AudiolibroDato(audio.ISBN, audio.Titulo, audio.Autor, audio.Editorial, audio.Año, audio.NSS,
                                          audio.Formato, audio.Duracion);
            }
            else
            {
                return new DocumentoDato(doc.ISBN, doc.Titulo, doc.Autor, doc.Editorial, doc.Año, doc.NSS);
            }
        }

        public static Documento DatoADocumento(DocumentoDato dd)
        {
            if (dd is LibroDato ld)
            {
                return new Libro(ld.Id, ld.Titulo, ld.Autor, ld.Editorial, ld.Año, ld.NSS);
            }
            else if (dd is AudiolibroDato ad)
            {
                return new Audiolibro(ad.Id, ad.Titulo, ad.Autor, ad.Editorial, ad.Año, ad.NSS, ad.Formato, ad.Duracion);
            }
            else
            {
                return new Documento(dd.Id, dd.Titulo, dd.Autor, dd.Editorial, dd.Año, dd.NSS);
            }
        }
    }
}
                                                                                                                                                                                                                                                                                             