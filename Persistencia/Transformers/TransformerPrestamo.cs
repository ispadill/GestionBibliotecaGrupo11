using ClassLibrary1;
using Persistencia.Datos;
using Persistencia.BDs;
using Persistencia.CRUD; // Necesitamos leer Usuario y Personal

namespace Persistencia.Transformers
{
    internal static class TransformersPrestamo
    {
        public static PrestamoDato PrestamoADato(Prestamo p)
        {
            bool estadoDato = (p.Estado == EstadoPrestamo.FINALIZADO);
            return new PrestamoDato(p.Id, p.FechaInicio, p.FechaFin, estadoDato, p.Usuario.Dni, p.Personal.NSS);
        }

        public static Prestamo DatoAPrestamo(PrestamoDato pd)
        {
            Usuario u = PersistenciaUsuario.READ(pd.DNI);
            PersonalSala ps = PersistenciaPersonal.READ(pd.NSS) as PersonalSala;

            EstadoPrestamo estado = pd.Estado ? EstadoPrestamo.FINALIZADO : EstadoPrestamo.EN_PROCESO;

            return new Prestamo(pd.Id, u, ps, pd.FInicio, pd.FFin, estado);
        }
    }
}