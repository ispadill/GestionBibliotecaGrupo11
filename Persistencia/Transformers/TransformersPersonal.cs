using ClassLibrary1;
using Persistencia.Datos;

namespace Persistencia.Transformers
{
    internal static class TransformersPersonal
    {
        public static PersonalDato PersonalADato(PersonalBiblioteca p)
        {
            if (p is PersonalSala ps)
            {
                return new PersonalSalaDato(ps.NSS, ps.Username, ps.Password, ps.Rol);
            }
            else if (p is PersonalAdquisiciones pa)
            {
                return new PersonalAdquisicionesDato(pa.NSS, pa.Username, pa.Password, pa.Rol);
            }
            return null;
        }

        public static PersonalBiblioteca DatoAPersonal(PersonalDato pd)
        {
            if (pd is PersonalSalaDato)
            {
                return new PersonalSala(pd.Id, pd.Nombre, pd.Contrasena, pd.Rol);
            }
            else if (pd is PersonalAdquisicionesDato)
            {
                return new PersonalAdquisiciones(pd.Id, pd.Nombre, pd.Contrasena, pd.Rol);
            }
            return null;
        }
    }
}