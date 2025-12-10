using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PersonalSala : PersonalBiblioteca
    {
        public PersonalSala(string nss, string username, string password, string rol)
            : base(nss, username, password, rol)
        {

        }
    }
}