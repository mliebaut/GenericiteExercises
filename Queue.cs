using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESI_DEV
{
    public class Queue<T> : GenericCollection<T>
    {
        public Queue() : base()
        {
        }

        public override T Get()
        {
            return list[0];
        }

        public override void Remove()
        {
            list.RemoveAt(0);
        }
    }
}
