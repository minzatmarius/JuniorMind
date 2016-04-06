using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector<T> : IList<T>
    {

        private T[] content;

        public Vector()
        {
            content = new T[0];
        }


        public Vector(T[] content)
        {
            this.content = new T[content.Length];
            for (int i = 0; i < content.Length; i++)
                this.content[i] = content[i];
        }

        public T this[int index]
        {
            get
            {
                return content[index];
            }

            set
            {
                throw new NotImplementedException();

            }
        }

        public int Count
        {
            get
            {
                int count = 0;
                for (int i = 0; i < content.Length; i++)
                {
                    if (!content[i].Equals(default(T))) count++;
                }
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

        public void Add(T item)
        {

            if (content.Length == Count)
                Array.Resize(ref content, content.Length * 2);

            if (content.Length == 0)
                Array.Resize(ref content, content.Length + 1);

            for (int i = 0; i < content.Length; i++)
            {
                if (content[i].Equals(default(T)))
                {
                    content[i] = item;
                    break;
                }
            }


        }


        public void Clear()
        {
            for(int i = 0; i< content.Length; i++)
            {
                content[i] = default(T);
            }
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i].Equals(item)) return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int length = array.Length;
            Array.Resize<T>(ref array, array.Length + content.Length);
            for (int i = arrayIndex + content.Length; i < array.Length; i++)
            {
                array[i] = array[i - content.Length];
            }
            for (int i = arrayIndex; i < content.Length; i++)
            {
                array[i] = content[i - arrayIndex];
            }


        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)content.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < content.Length; i++)
            {

                if (content[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;


        }

        public void Insert(int index, T item)
        {
            Array.Resize<T>(ref content, content.Length + 1);
            for (int i = content.Length - 1; i > index; i--)
            {
                content[i] = content[i - 1];
            }
            content[index] = item;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            T[] contentCopy = content;
            if (index == -1) return false;
            RemoveAt(index);
            return true;
        }

        public void RemoveAt(int index)
        {
            content[index] = default(T);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();

        }
    }
}