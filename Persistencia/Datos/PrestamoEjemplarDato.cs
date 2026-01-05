using Persistencia.Claves;
using System;

namespace Persistencia.Datos
{
    public class PrestamoEjemplarDato : Entity<ClavePrestamoEjemplar>
    {
        public DateTime FDevolucion { get; set; }

        public PrestamoEjemplarDato(ClavePrestamoEjemplar clave, DateTime fDevolucion)
            : base(clave)
        {
            FDevolucion = fDevolucion;
        }
    }
}