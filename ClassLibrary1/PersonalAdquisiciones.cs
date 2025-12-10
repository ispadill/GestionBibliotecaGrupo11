using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PersonalAdquisiciones : PersonalBiblioteca
    {
        public PersonalAdquisiciones(string nss, string username, string password, string rol)
            : base(nss, username, password, rol)
        {

        }
    }
}