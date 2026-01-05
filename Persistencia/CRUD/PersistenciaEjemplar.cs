using System;
using System.Collections.Generic;
using ClassLibrary1;
using Persistencia.Datos;
using Persistencia.Claves; 
using Persistencia.Transformers;

namespace Persistencia.CRUD
{
    public static class PersistenciaEjemplar
    {
        public static void CREATE(Ejemplar e, string nssPersonal)
        {
            EjemplarDato ed = TransformersEjemplar.EjemplarADato(e);
            ed.NSS = nssPersonal;
            ed.Estado = false; 

            if (!BD.TablaEjemplar.Contains(ed.Id))
                BD.TablaEjemplar.Add(ed);
            else
                throw new Exception("El ejemplar ya existe.");
        }

        public static Ejemplar READ(string isbn, string codigo)
        {
            ClaveEjemplar clave = new ClaveEjemplar(isbn, codigo);
            if (BD.TablaEjemplar.Contains(clave))
                return TransformersEjemplar.DatoAEjemplar(BD.TablaEjemplar[clave]);
            return null;
        }

        public static List<Ejemplar> READ_DISPONIBLES(string isbn)
        {
            List<Ejemplar> disponibles = new List<Ejemplar>();
            foreach (var dato in BD.TablaEjemplar)
            {
                if (dato.Id.ISBN == isbn && dato.Estado == true)
                {
                    disponibles.Add(TransformersEjemplar.DatoAEjemplar(dato));
                }
            }
            return disponibles;
        }

        public static void UPDATE(Ejemplar e)
        {
            EjemplarDato ed = TransformersEjemplar.EjemplarADato(e);
            if (BD.TablaEjemplar.Contains(ed.Id))
            {

                ed.NSS = BD.TablaEjemplar[ed.Id].NSS;
                BD.TablaEjemplar.Remove(ed.Id);
                BD.TablaEjemplar.Add(ed);
            }
        }
        public static void DELETE(Ejemplar e)
        {
            EjemplarDato ed = TransformersEjemplar.EjemplarADato(e);
            if (BD.TablaEjemplar.Contains(ed.Id))
            {
                BD.TablaEjemplar.Remove(ed.Id);
            }
        }
    }
}