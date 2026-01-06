using ClassLibrary1;
using Persistencia.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class LNPersonalSala : LNPersonalBiblioteca
    {
        private PersonalSala pSala;

        public LNPersonalSala(PersonalSala pSala)
        {
            this.p = pSala;
            this.pSala = pSala;
        }
        /*PRE:
         * idPrestamo debe ser único
         * dniUsuario debe corresponder a un usuario existente en la base de datos.
         * ejemplares debe ser una lista inicializada y contener al menos un elemento.
         * Los ejemplares en la lista deben estar disponibles
         */
        /*POST:
         * Se crea y almacena un nuevo objeto Prestamo en la base de datos.
         * El estado de los ejemplares involucrados se actualiza a Prestado = true
         * Se define la fecha de fin (devolución) calculando 10 días si hay audiolibros o 15 días si son solo libros.
         */
        public void AltaPrestamo(int idPrestamo, string dniUsuario, List<Ejemplar> ejemplares)
        {
            Usuario u = BuscarUsuario(dniUsuario);
            if (u == null)
            {
                throw new Exception("El usuario no existe.");
            }
            if (ejemplares == null || ejemplares.Count == 0)
            {
                throw new Exception("Debes seleccionar al menos un ejemplar.");
            }

            DateTime inicio = DateTime.Now;

            int dias = ejemplares.Any(e => e.Documento is AudioLibro) ? 10 : 15;
            DateTime fin = inicio.AddDays(dias);

            Prestamo prestamo = new Prestamo(idPrestamo, u, pSala, inicio, fin, EstadoPrestamo.EN_PROCESO);

     
            foreach (var ej in ejemplares)
            {
                prestamo.Ejemplares.Add(ej);
            }

            PersistenciaPrestamo.CREATE(prestamo);
        }
        //PRE: -
        //POST: POST: Si el ejemplar existe, su estado se actualiza a Prestado = false. Si no existe, no realiza ninguna acción.
        public void DevolverEjemplar(string isbn, string codigo)
        {
            Ejemplar ej = PersistenciaEjemplar.READ(isbn, codigo);
            if (ej != null)
            {
                ej.marcarPrestado(false);
                PersistenciaEjemplar.UPDATE(ej);
            }
        }
        //PRE: -
        //POST: Devuelve el objeto Prestamo correspondiente al ID, o null si no existe.
        public Prestamo BuscarPrestamo(int id)
        {
            return PersistenciaPrestamo.READ(id);
        }
        //PRE: -
        //POST: Devuelve una lista de objetos Ejemplar asociados a ese ISBN cuyo estado sea no prestado.
        public List<Ejemplar> BuscarEjemplaresDisponibles(string isbn)
        {
            return PersistenciaEjemplar.READ_DISPONIBLES(isbn);
        }

        //PRE: El dni debe corresponder a un usuario registrado.
        //POST: Devuelve una lista de strings con la información de los préstamos activos (Estado = false). Si no hay préstamos, devuelve una lista vacía.
        public List<string> ConsultarPrestamosActivos(string dni)
        {
            List<string> lista = new List<string>();
            foreach (var p in Persistencia.BD.TablaPrestamo)
            {
                if (p.DNI == dni && p.Estado == false) // false = En proceso [cite: 151]
                {
                    lista.Add($"Préstamo #{p.Id} - Vence: {p.FFin.ToShortDateString()}");
                }
            }
            return lista;
        }

        //PRE: La base de datos de préstamos debe estar accesible.
        //POST: Devuelve una lista de strings con los datos de préstamos cuyo Estado es "false" y su fecha de fin es anterior a la fecha actual.
        public List<string> ConsultarPrestamosFueraDePlazo()
        {
            List<string> lista = new List<string>();
            DateTime hoy = DateTime.Today;

            foreach (var p in Persistencia.BD.TablaPrestamo)
            {
                if (p.Estado == false && p.FFin < hoy)
                {
                    lista.Add($"Retraso -> DNI: {p.DNI} (Venció: {p.FFin.ToShortDateString()})");
                }
            }
            return lista;
        }


        

    }
}
