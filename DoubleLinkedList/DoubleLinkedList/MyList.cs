using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class MyList<T> : IEnumerable<T>
    {
        public Node<T> guard;
        private int count;
        public MyList()
        {
            guard = new Node<T>(default(T));
            guard.next = guard;
            guard.previous = guard;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Add(T data)
        {
            AddLast(data);
        }

        public void AddLast(T data)
        {
            Node<T> last = guard.previous;
            Node<T> current = new Node<T>(data);
            last.next = current;
            guard.previous = current;
            count++;
            current.previous = last;
            current.next = guard;

        }

        public void AddFirst(T data)
        {
            Node<T> second = guard.next;
            Node<T> current = new Node<T>(data);
            second.previous = current;
            guard.next = current;
            current.previous = guard;
            current.next = second;
            count++;

        }

        public bool Contains(T value)
        {
            return (IndexOf(value) != -1);
        }

        public Node<T> GetAt(int index)
        {
            var current = guard.next;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            return current;
        }

        public int IndexOf(T data)
        {
            var current = guard.next;
            for (int i = 0; i < count; i++)
            {
                if (current.data.Equals(data))
                    return i;
                current = current.next;
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            var current = GetAt(index);
            var previous = current.previous;
            var next = current.next;
            previous.next = next;
            next.previous = previous;
            count--;
        }

        public void Remove(T data)
        {
            Node<T> current = guard.next;
            for (int i = 0; i< count; i++) 
            {
                if (current.data.Equals(data))
                {
                    var previousNode = current.previous;
                    var nextNode = current.next;
                    previousNode.next = nextNode;
                    nextNode.previous = previousNode;
                    count--;
                    break;
                }
                current = current.next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var node = guard.next;
            while (!node.data.Equals(guard.data))
            {
                yield return node.data;
                node = node.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();

        }
    }
}
