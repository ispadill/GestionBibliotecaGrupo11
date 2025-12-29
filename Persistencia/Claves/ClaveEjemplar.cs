using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Claves
{
    internal class ClaveEjemplar : IEquatable<ClaveEjemplar>
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

        public override bool Equals(object obj) //tengo duda de si esto esta bien
        {
            return Equals(obj as ClaveEjemplar);
        }

        public override int GetHashCode() // redefinido el getHashCode
        {
            return HashCode.Combine(ISBN, Codigo);
        }
    }
}