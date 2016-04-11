using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Node
    {
        private object data;
        Node next;

        public Node(object data)
        {
            this.data = data;
            next = null;
        }
    }
}
