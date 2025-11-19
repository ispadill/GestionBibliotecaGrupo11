using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class PersonalAdquisiciones : PersonalBiblioteca
    {
        private static string nss;
        private static string username;
        private static string password;
        private static string rol;
        public PersonalAdquisiciones() : base(nss, username, password, rol)
        {

        }
    }
}
