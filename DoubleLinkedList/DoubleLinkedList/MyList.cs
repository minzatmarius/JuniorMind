using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class MyList<T> : LinkedList<T>
    {
        private Node guard;
        private int count;
        public MyList()
        {
            guard = new Node(default(T));
            guard.next = guard;
            guard.previous = guard;
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
            Node last = guard.previous;
            Node current = new Node(data);
            last.next = current;
            guard.previous = current;
            count++;
            current.previous = last;
            current.next = guard;

        }

        public new void AddFirst(T data)
        {
            Node second = guard.next;
            Node current = new Node(data);
            second.previous = current;
            guard.next = current;
            current.previous = guard;
            current.next = second;
            count++;

        }

        public new IEnumerator<Node> GetEnumerator()
        {
            var node = guard.next;
            while (node != guard)
            {
                yield return node;
                node = node.next;
            }
        }

        public new bool Contains(T value)
        {
            var node = guard.next;
            while (node != guard)
            {
                if (node.data.Equals(value))
                    return true;
                node = node.next;
            }
            return false;
        }


    }
}
