using ClassLibrary1;
using Persistencia.Claves; 
using Persistencia.Datos;  
using Persistencia.BDs;    

namespace Persistencia.Transformers
{
    internal static class TransformersEjemplar
    {
        public static EjemplarDato EjemplarADato(Ejemplar e)
        {
            int codigoInt = int.Parse(e.Codigo);
            ClaveEjemplar clave = new ClaveEjemplar(e.Documento.ISBN, codigoInt);

            return new EjemplarDato(clave, !e.Prestado, "");
        }

        public static Ejemplar DatoAEjemplar(EjemplarDato ed)
        {
            Documento doc = PersistenciaDocumento.READ(ed.Id.ISBN);

            return new Ejemplar(ed.Id.Codigo.ToString(), !ed.Estado, doc);
        }
    }
}