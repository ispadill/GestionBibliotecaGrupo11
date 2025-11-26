using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{   
    internal class Prestamo
    {
        private int id;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private EstadoPrestamo estado;
        private PersonalSala responsable;
        private List<Ejemplar> ejemplaresPrestados;

        public Prestamo(int id, DateTime fechaInic, DateTime fechaFin, EstadoPrestamo ep, PersonalSala responsable, List<Ejemplar> ejemplares) { 
            this.id = id;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.estado = ep;
            this.responsable = responsable;
            this.ejemplaresPrestados = ejemplares;
        }

        public int ID { get { return id; } set { id = value; } }
        public DateTime FechaInicio { get { return fechaInicio; } set { fechaInicio = value; } }
        public DateTime FechaFin { get { return fechaFin; } set { fechaFin = value; } }
        public EstadoPrestamo EstadoPrestamo { get { return estado; } set { estado = value; } }    
        public PersonalSala Responsable { get { return responsable; } set { responsable = value; } }



    }
}
