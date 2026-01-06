using ClassLibrary1;
using Persistencia.Datos;
using Persistencia.CRUD; 

namespace Persistencia.Transformers
{
    internal static class TransformersPrestamo
    {
        //PRE: p no es nulo.
        //POST: Devuelve el PrestamoDato correspondiente al Prestamo p.
        public static PrestamoDato PrestamoADato(Prestamo p)
        {
            bool estadoDato = (p.Estado == EstadoPrestamo.FINALIZADO);
            return new PrestamoDato(p.Id, p.FechaInicio, p.FechaFin, estadoDato, p.Usuario.Dni, p.Personal.NSS);
        }
        //PRE: pd no es nulo.
        //POST: Devuelve una instancia completa de Prestamo.
        public static Prestamo DatoAPrestamo(PrestamoDato pd)
        {
            Usuario u = PersistenciaUsuario.READ(pd.DNI);
            PersonalSala ps = PersistenciaPersonal.READ(pd.NSS) as PersonalSala;

            EstadoPrestamo estado = pd.Estado ? EstadoPrestamo.FINALIZADO : EstadoPrestamo.EN_PROCESO;

            return new Prestamo(pd.Id, u, ps, pd.FInicio, pd.FFin, estado);
        }
    }
}