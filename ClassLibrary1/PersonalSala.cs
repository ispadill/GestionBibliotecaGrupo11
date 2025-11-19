using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class PersonalSala : PersonalBiblioteca
    {
        private static string nss;
        private static string username;
        private static string password;
        private static string rol;
        public PersonalSala() : base(nss, username, password, rol)
        {
            
        }   

    }
}
