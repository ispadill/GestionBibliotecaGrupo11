using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Usuario     
    {
        private string dni;
        private string nombre;

        public Usuario(String dni, String nombre) {
            this.dni = dni;
            this.nombre = nombre;
        }


        public string Dni { 
            get { return dni; } 
        }
        public string Nombre
        {
            get { return nombre; }
        }
    }
}
