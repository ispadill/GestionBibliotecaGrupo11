using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Claves
{
    public class ClaveEjemplar : IEquatable<ClaveEjemplar>
    {
        public string ISBN { get; }
        public string Codigo { get; }

        public ClaveEjemplar(string isbn, string codigo)
        {
            ISBN = isbn;
            Codigo = codigo;
        }

        public bool Equals(ClaveEjemplar other)
        {
            if (other is null) return false;

            return ISBN == other.ISBN &&
                   Codigo == other.Codigo;
        }

        public override bool Equals(object obj) 
        {
            return Equals(obj as ClaveEjemplar);
        }

        public override int GetHashCode()
        {
            unchecked 
            {
                int hash = 17;
                hash = hash * 23 + (ISBN != null ? ISBN.GetHashCode() : 0);
                hash = hash * 23 + (Codigo != null ? Codigo.GetHashCode() : 0);
                return hash;
            }
        }
    }
}