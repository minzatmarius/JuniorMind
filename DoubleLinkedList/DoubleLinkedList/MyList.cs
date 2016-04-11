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
        public MyList()
        {
            headNode = null;
        }      
        
        public void AddToEnd(object data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                AddToEnd
            }
        }
    }
}
