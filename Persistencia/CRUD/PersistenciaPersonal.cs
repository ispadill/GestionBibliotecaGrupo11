using System;
using System.Collections.Generic;
using ClassLibrary1;
using Persistencia.Datos;
using Persistencia.Transformers;

namespace Persistencia.BDs // OJO: Si decidiste usar la carpeta CRUD, cambia esto a namespace Persistencia.CRUD
{
    public static class PersistenciaPersonal
    {
        // ------------------- CREATE -------------------
        public static void CREATE(PersonalBiblioteca p)
        {
            PersonalDato pd = TransformersPersonal.PersonalADato(p);
            if (!BD.TablaPersonal.Contains(pd.Id))
            {
                BD.TablaPersonal.Add(pd);
            }
            else
            {
                throw new Exception("Ya existe un empleado con ese NSS.");
            }
        }

        // ------------------- READ -------------------
        public static PersonalBiblioteca READ(string nss)
        {
            if (BD.TablaPersonal.Contains(nss))
                return TransformersPersonal.DatoAPersonal(BD.TablaPersonal[nss]);
            return null;
        }

        // ------------------- UPDATE -------------------
        public static void UPDATE(PersonalBiblioteca p)
        {
            // Verificamos si existe antes de intentar actualizar
            if (BD.TablaPersonal.Contains(p.NSS))
            {
                // Borramos el registro viejo (CORREGIDO: antes decía TablaDocumento)
                BD.TablaPersonal.Remove(p.NSS);

                // Añadimos el nuevo con los datos actualizados
                CREATE(p);
            }
            else
            {
                throw new Exception("No se puede actualizar: El empleado no existe.");
            }
        }

        // ------------------- DELETE -------------------
        public static void DELETE(PersonalBiblioteca p)
        {
            if (BD.TablaPersonal.Contains(p.NSS))
            {
                BD.TablaPersonal.Remove(p.NSS);
            }
        }

        // ------------------- EXTRA: LOGIN -------------------
        // Necesario para verificar usuario y contraseña al entrar
        public static PersonalBiblioteca LOGIN(string username, string password)
        {
            foreach (var dato in BD.TablaPersonal)
            {
                if (dato.Nombre == username && dato.Contrasena == password)
                {
                    return TransformersPersonal.DatoAPersonal(dato);
                }
            }
            return null;
        }
    }
}