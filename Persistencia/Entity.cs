using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public abstract class Entity<T>
    {
        private T id;
        public T Id
        {
            get
            {
                return this.id;
            }
        }

        public Entity(T id)
        {
            this.id = id;
        }
    }
}