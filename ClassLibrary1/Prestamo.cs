using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Prestamo
    {
        private int id;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private EstadoPrestamo estado;

        private Usuario usuario;
        private PersonalSala personal;
        private List<Ejemplar> ejemplares;

        public Prestamo(int id, Usuario usuario, PersonalSala personal,
                        DateTime fechaInicio, DateTime fechaFin, EstadoPrestamo estado)
        {
            this.id = id;
            this.usuario = usuario;
            this.personal = personal;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.estado = estado;

            this.ejemplares = new List<Ejemplar>();
        }

        public int Id { get { return id; } }
        public DateTime FechaInicio { get { return fechaInicio; } set { fechaInicio = value; } }
        public DateTime FechaFin { get { return fechaFin; } set { fechaFin = value; } }
        public EstadoPrestamo Estado { get { return estado; } set { estado = value; } }

        public Usuario Usuario { get { return usuario; } }
        public PersonalSala Personal { get { return personal; } }

        public List<Ejemplar> Ejemplares { get { return ejemplares; } }
    }
}
