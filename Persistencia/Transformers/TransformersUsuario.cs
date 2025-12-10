using ClassLibrary1;
using Persistencia.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Transformers
{
    internal static class TransformersUsuario
    {
        public static UsuarioDato UsuarioADato(Usuario u)
        {
            if (u == null) return null;
            return new UsuarioDato(u.Dni, u.Nombre);
        }

        public static Usuario DatoAUsuario(UsuarioDato ud)
        {
            if (ud == null) return null;
            return new Usuario(ud.Id, ud.Nombre);
        }
    }
}