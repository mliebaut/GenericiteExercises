using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESI_DEV
{
    public class Stack<T> : GenericCollection<T>
    {
        public Stack() : base()
        {
        }

        public override T Get()
        {
            return list[list.Count - 1];
        }

        public override void Remove()
        {
            list.RemoveAt(list.Count - 1);
        }
    }
}
