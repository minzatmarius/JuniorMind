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
        private int count = 0;

        public Vector()
        {
            content = new T[8];
        }


        public Vector(T[] content)
        {
            this.content = new T[content.Length];
            for (int i = 0; i < content.Length; i++)
            {
                this.content[i] = content[i];
                count++;
            }
        }

        public T this[int index]
        {
            get
            {
                return content[index];
            }

            set
            {
                content[index] = value;

            }
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

        public void Add(T item)
        {
            Resize();
            content[count] = item;
            count++;

        }

        public void Clear()
        {
            count = 0;
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
            int j = arrayIndex;
            for (int i = 0; i < count; i++)
            {
                array.SetValue(content[i], j);
                j++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < content.Length; i++)
            {
                yield return content[i];
            }
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
            if (index != -1) 
            {
                RemoveAt(index);
                return true;

            }
            return false;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < content.Length - 1; i++)
            {
                content[i] = content[i + 1];
            }
            count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();

        }

        private void Resize()
        {
            if (content.Length == count)
                Array.Resize(ref content, content.Length * 2);
        }
    }
}