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
        
        public Usuario BuscarUsuario(string dni)
        {
            return PersistenciaUsuario.READ(dni);
        }
        public List<Usuario> ListarUsuarios()
        {
            return PersistenciaUsuario.READALL();
        }
        public static LNPersonalBiblioteca IniciarSesion(string usuario, string contra)
        {
            PersonalBiblioteca p = PersistenciaPersonal.LOGIN(usuario, contra);
            return p;
        }
    }
}
