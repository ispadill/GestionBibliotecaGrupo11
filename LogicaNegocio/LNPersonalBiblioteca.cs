using ClassLibrary1;
using Persistencia.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public abstract class LNPersonalBiblioteca
    {
        protected PersonalBiblioteca p;
        //PRE: -
        //POST: Devuelve el objeto Usuario si existe un usuario con ese DNI en la base de datos; devuelve null en caso contrario.
        public Usuario BuscarUsuario(string dni)
        {
            return PersistenciaUsuario.READ(dni);
        }
        //PRE: -
        //POST: Devuelve una lista con todos los usuarios registrados en el sistema.
        public List<Usuario> ListarUsuarios()
        {
            return PersistenciaUsuario.READALL();
        }
        //PRE: usuario y contra representan las credenciales de un empleado.
        //POST: Devuelve una instancia concreta de LNPersonalBiblioteca si las credenciales son válidas y coinciden con un rol; devuelve null si son incorrectas.
        public static LNPersonalBiblioteca IniciarSesion(string usuario, string contra)
        {
            PersonalBiblioteca p = PersistenciaPersonal.LOGIN(usuario, contra);
            if (p is PersonalSala pSala)
            {
                return new LNPersonalSala(pSala);
            }
            if(p is PersonalAdquisiciones pAdq)
            {
                return new LNPersonalAdquisiciones(pAdq);
            }
            return null;
        }
        //PRE: El dni no debe existir previamente en la base de datos.
        //POST: Se crea un nuevo Usuario en la base de datos con los datos proporcionados. Si los datos están vacíos, lanza una Excepción.
        public void AltaUsuario(string dni, string nombre)
        {
            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(nombre))
                throw new Exception("El DNI y el Nombre son obligatorios.");

            Usuario nuevo = new Usuario(dni, nombre);
            Persistencia.CRUD.PersistenciaUsuario.CREATE(nuevo);
        }



    }
}
