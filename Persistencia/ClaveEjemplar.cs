using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class ClaveEjemplar : IEquatable<ClaveEjemplar>
    {
        public string ISBN { get; }
        public int Codigo { get; }

        public ClaveEjemplar(string isbn, int codigo)
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

        public override int GetHashCode() // redefinido el getHashCode
        {
            return HashCode.Combine(ISBN, Codigo);
        }
    }
}