using System;
using System.Collections.Generic;
using ClassLibrary1;
using Persistencia.Datos;
using Persistencia.Claves;
using Persistencia.Transformers;

namespace Persistencia.CRUD
{
    public static class PersistenciaPrestamo
    {
        //PRE: p.Id no debe existir en BD.TablaPrestamo.
        //POST: Se guarda una entrada en BD.TablaPrestamoEjemplar por cada ejemplar.
        public static void CREATE(Prestamo p)
        {
            PrestamoDato pd = TransformersPrestamo.PrestamoADato(p);
            if (BD.TablaPrestamo.Contains(pd.Id))
                throw new Exception("El ID de préstamo ya existe.");

            BD.TablaPrestamo.Add(pd);

            foreach (Ejemplar e in p.Ejemplares)
            {
                ClavePrestamoEjemplar clave = new ClavePrestamoEjemplar(p.Id, e.Codigo);
                PrestamoEjemplarDato ped = new PrestamoEjemplarDato(clave, DateTime.MinValue);
                BD.TablaPrestamoEjemplar.Add(ped);

                e.marcarPrestado(true);
                PersistenciaEjemplar.UPDATE(e);
            }
        }

        public static Prestamo READ(int idPrestamo)
        {
            if (!BD.TablaPrestamo.Contains(idPrestamo)) return null;

            Prestamo prestamo = TransformersPrestamo.DatoAPrestamo(BD.TablaPrestamo[idPrestamo]);

            foreach (var item in BD.TablaPrestamoEjemplar)
            {
                if (item.Id.IdPrestamo == idPrestamo)
                {
                    foreach (var ejDato in BD.TablaEjemplar)
                    {
                        if (ejDato.Id.Codigo.ToString() == item.Id.CodigoEjemplar)
                        {
                            Ejemplar e = TransformersEjemplar.DatoAEjemplar(ejDato);
                            prestamo.Ejemplares.Add(e);
                        }
                    }
                }
            }
            return prestamo;
        }

    }
}