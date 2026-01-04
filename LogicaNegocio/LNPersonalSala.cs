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
        public void AltaPrestamo(int idPrestamo, string dniUsuario, List<Ejemplar> ejemplares)
        {
            Usuario u = BuscarUsuario(dniUsuario);
            if(u == null)
            {
                throw new Exception("El usuario no existe.");
            }
            if(ejemplares == null || ejemplares.Count == 0)
            {
                throw new Exception("Debes seleccionar un ejemplar.");
            }
            DateTime inicio = DateTime.Now;
            DateTime fin = inicio.AddDays(15);
            Prestamo prestamo = new Prestamo(idPrestamo, u, pSala, inicio, fin, EstadoPrestamo.EN_PROCESO);
        }
        public Prestamo BuscarPrestamo(int id)
        {
            return PersistenciaPrestamo.READ(id);
        }
        public List<Ejemplar> BuscarEjemplaresDisponibles(string isbn)
        {
            return PersistenciaEjemplar.READ_DISPONIBLES(isbn);
        }
    }
}
