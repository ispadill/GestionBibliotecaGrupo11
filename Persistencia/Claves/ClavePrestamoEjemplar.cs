using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Claves
{
    public class ClavePrestamoEjemplar : IEquatable<ClavePrestamoEjemplar>
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
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (IdPrestamo != null ? IdPrestamo.GetHashCode() : 0);
                hash = hash * 23 + (CodigoEjemplar != null ? CodigoEjemplar.GetHashCode() : 0);
                return hash;
            }
        }
    }
}
