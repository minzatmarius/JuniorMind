using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class MyList<T> : IEnumerable<T>, ICollection<T>
    {
        private Node<T> guard;
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

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T data)
        {
            AddLast(data);
        }

        public void AddLast(T data)
        {
            var last = guard.previous;
            var current = new Node<T>(data) { previous = last, next = guard };
            last.next = current;
            guard.previous = current;
            count++;

        }

        public void AddFirst(T data)
        {
            var second = guard.next;
            var current = new Node<T>(data) { previous = guard, next = second };
            second.previous = current;
            guard.next = current;
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
            RemoveNode(GetAt(index));
        }

        public void Remove(T data)
        {
            Node<T> current = guard.next;
            for (int i = 0; i< count; i++) 
            {
                if (current.data.Equals(data))
                {
                    RemoveNode(current);
                    break;
                }
                current = current.next;
            }
        }

        private void RemoveNode(Node<T> current)
        {
            var previousNode = current.previous;
            var nextNode = current.next;
            previousNode.next = nextNode;
            nextNode.previous = previousNode;
            count--;
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
            var node = guard.next;
            while (!node.data.Equals(guard.data))
            {
                yield return node.data;
                node = node.next;
            }
        }

        public void Clear()
        {
            count = 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var j = guard.next;
            int end = Math.Min(array.Length, count + arrayIndex);
            for (int i = arrayIndex; i < end; i++)
            {
                array.SetValue(j.data, i);
                j=j.next;
            }
    
        }

        bool ICollection<T>.Remove(T item)
        {
            return !Contains(item);
        }
    }
}
