using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Persistencia.Datos;
using Persistencia.Transformers;

namespace Persistencia.BDs
{
    public static class PersistenciaDocumento
    {
        // -------------------- CREATE --------------------
        public static void CREATE(Documento doc)
        {
            // Convertimos a DocumentoDato según el tipo
            DocumentoDato dd = TransformersDocumento.DocumentoADato(doc);

            // Añadimos a la tabla simulada
            BD.TablaDocumento.Add(dd);
        }

        // -------------------- UPDATE --------------------
        public static void UPDATE(Documento doc)
        {
            DocumentoDato dd = TransformersDocumento.DocumentoADato(doc);

            if (BD.TablaDocumento.Contains(dd.Id))
            {
                BD.TablaDocumento.Remove(dd.Id);
            }

            CREATE(doc);
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