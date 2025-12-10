using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Claves
{
    internal class ClavePrestamoEjemplar : IEquatable<ClavePrestamoEjemplar>
    {
        public int IdPrestamo { get; }
        public string CodigoEjemplar { get; }

        public ClavePrestamoEjemplar(int idPrestamo, string codigoEjemplar)
        {
            IdPrestamo = idPrestamo;
            CodigoEjemplar = codigoEjemplar;
        }

        public bool Equals(ClavePrestamoEjemplar other)
        {
            if (other is null) return false;

            return IdPrestamo == other.IdPrestamo &&
                   CodigoEjemplar == other.CodigoEjemplar;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ClavePrestamoEjemplar);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IdPrestamo, CodigoEjemplar);
        }
    }
}
