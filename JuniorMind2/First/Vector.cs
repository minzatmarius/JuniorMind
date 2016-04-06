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
        private int count;

        public Vector()
        {
            content = new T[0];
        }


        public Vector(T[] content)
        {
            this.content = new T[content.Length];
            for(int i = 0; i< content.Length; i++)
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
                return count;
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            

            Array.Resize(ref content, content.Length + 1);
            content[content.Length -1] = item;


        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(T item)
        {
            for(int i = 0; i < content.Length; i++)
            {
                if (content[i].Equals(item)) return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)content.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < content.Length - 1; i++)
            {
                
                if(content[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;

            throw new NotImplementedException();

        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();

        }
    }
}
