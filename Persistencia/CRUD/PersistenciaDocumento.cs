using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Persistencia.Datos;
using Persistencia.Transformers;

namespace Persistencia.CRUD
{
    public static class PersistenciaDocumento
    {
        // -------------------- CREATE --------------------
        public static void CREATE(Documento doc, string nss)
        {
            DocumentoDato dd = TransformersDocumento.DocumentoADato(doc);
            dd.NSS = nss;

            BD.TablaDocumento.Add(dd);
        }

        // -------------------- UPDATE --------------------
        public static void UPDATE(Documento doc)
        {
            DocumentoDato dd = TransformersDocumento.DocumentoADato(doc);

            if (BD.TablaDocumento.Contains(dd.Id))
            {
                dd.NSS = BD.TablaDocumento[dd.Id].NSS;
                BD.TablaDocumento.Remove(dd.Id);
                BD.TablaDocumento.Add(dd);
            }
        }

        // -------------------- DELETE --------------------
        public static void DELETE(Documento doc)
        {
            DocumentoDato dd = TransformersDocumento.DocumentoADato(doc);

            if (BD.TablaDocumento.Contains(dd.Id))
            {
                BD.TablaDocumento.Remove(dd.Id);
            }
        }

        // -------------------- READ --------------------
        public static Documento READ(string isbn)
        {
            if (BD.TablaDocumento.Contains(isbn))
            {
                DocumentoDato dd = BD.TablaDocumento[isbn];
                return TransformersDocumento.DatoADocumento(dd);
            }
            return null;
        }
    }

}