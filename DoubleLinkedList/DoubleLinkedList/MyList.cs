using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class MyList<T> :LinkedList<T>
    {
        private Node headNode;
        private int count;
        public MyList()
        {
            headNode = null;
       
        }

        public new int Count
        {
            get
            {
                return count;
            }
        }

        public new void AddLast(T data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
                count++;

            }
            else
            {
                headNode.AddAfter(data);
                count++;
            }
        }
    }
}
