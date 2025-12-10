using Persistencia.Claves;

namespace Persistencia.Datos
{
    internal class PrestamoEjemplarDato : Entity<ClavePrestamoEjemplar>
    {
        public DateTime FDevolucion { get; set; }

        public PrestamoEjemplarDato(ClavePrestamoEjemplar clave, DateTime fDevolucion)
            : base(clave)
        {
            FDevolucion = fDevolucion;
        }
    }
}