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

        public void DevolverEjemplar(string isbn, string codigo)
        {
            Ejemplar ej = PersistenciaEjemplar.READ(isbn, codigo);
            if (ej != null)
            {
                ej.marcarPrestado(false);
                PersistenciaEjemplar.UPDATE(ej);
            }
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
