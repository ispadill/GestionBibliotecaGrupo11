using ClassLibrary1;
using Persistencia.Claves; 
using Persistencia.Datos; 
using Persistencia.CRUD;

namespace Persistencia.Transformers
{
    internal static class TransformersEjemplar
    {
        //PRE: e no es nulo.
        //POST: Devuelve el EjemplarDato correspondiente al Ejemplar e.
        public static EjemplarDato EjemplarADato(Ejemplar e)
        {
            ClaveEjemplar clave = new ClaveEjemplar(e.Documento.ISBN, e.Codigo);

            return new EjemplarDato(clave, !e.Prestado, "");
        }
        //PRE: ed no es nulo.
        //POST: Devuelve una instancia completa de Ejemplar.
        public static Ejemplar DatoAEjemplar(EjemplarDato ed)
        {
            Documento doc = PersistenciaDocumento.READ(ed.Id.ISBN);

            return new Ejemplar(ed.Id.Codigo.ToString(), !ed.Estado, doc);
        }
    }
}