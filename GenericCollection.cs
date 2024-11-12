using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESI_DEV
{
    public abstract class GenericCollection<T>
    {
        protected List<T> list;

        public GenericCollection()
        {
            list = new List<T>();
        }

        public void Add(T valueToAdd)
        {
            list.Add(valueToAdd);
        }

        public abstract T Get();

        public abstract void Remove();

        public T GetAndRemove()
        {
            T toReturn = Get();
            Remove();

            return toReturn;
        }
    }
}
