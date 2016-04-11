using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Node
    {
        public object data;
        public Node next;

        public Node(object data)
        {
            this.data = data;
            next = null;
        }


        public void AddAfter(object data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddAfter(data);
            }
        }
    }
}
