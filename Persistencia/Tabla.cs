using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Persistencia.Claves;

namespace Persistencia
{
    public class Tabla<T, u> : KeyedCollection<T, u> where u : Entity<T>
    {
        public object Find(ClaveEjemplar clave)
        {
            throw new NotImplementedException();
        }

        protected override T GetKeyForItem(u item)
        {
            return item.Id;
        }
    }
}