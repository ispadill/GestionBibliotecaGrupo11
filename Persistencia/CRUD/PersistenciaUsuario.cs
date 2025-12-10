using System;
using System.Collections.Generic;
using ClassLibrary1;
using Persistencia.Datos;
using Persistencia.Transformers;

namespace Persistencia.CRUD
{
    public static class PersistenciaUsuario
    {
        public static void CREATE(Usuario u)
        {
            UsuarioDato ud = TransformersUsuario.UsuarioADato(u);
            if (!BD.TablaUsuario.Contains(ud.Id))
                BD.TablaUsuario.Add(ud);
            else
                throw new Exception("El usuario ya existe.");
        }

        public static Usuario READ(string dni)
        {
            if (BD.TablaUsuario.Contains(dni))
                return TransformersUsuario.DatoAUsuario(BD.TablaUsuario[dni]);
            return null;
        }

        public static List<Usuario> READALL()
        {
            List<Usuario> lista = new List<Usuario>();
            foreach (var ud in BD.TablaUsuario)
                lista.Add(TransformersUsuario.DatoAUsuario(ud));
            return lista;
        }

        public static void DELETE(string dni)
        {
            if (BD.TablaUsuario.Contains(dni))
                BD.TablaUsuario.Remove(dni);
        }
    }
}