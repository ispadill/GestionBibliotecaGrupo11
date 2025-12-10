using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class PersonalBiblioteca
    {
        private string nss;
        private string username;
        private string password;
        private string rol;

        public PersonalBiblioteca(string nss, string username, string password, string rol)
        {
            this.nss = nss;
            this.username = username;
            this.password = password;
            this.rol = rol;
        }

        public string NSS
        { 
            get { return nss; }
        }

        public string Username 
        {   get { return this.username; } 
            set { this.username = value; }
        }
        public string Password {
            get { return this.password; }
            set { this.password = value; }
        }

        public string Rol 
        { get { return this.rol; } 
            set { this.rol = value; } 
        }
    }
}
