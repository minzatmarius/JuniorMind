using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Hashtable<TKey, TValue> : IDictionary<TKey, TValue>
    {
        public int[] buckets = new int[8];
        public struct Table
        {
            public TKey key;
            public TValue value;
            public Table(TKey key, TValue value)
            {
                this.key = key;
                this.value = value;
            }
        }
        public Table[] items = new Table[8]; 
        private int countBuckets;
        private int countItems;
       


        public TValue this[TKey key]
        {


            get
            {
                throw new NotImplementedException();
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
                return countItems;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<TKey> Keys
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }



        public void Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(TKey key)
        {
            for (int i = 0; i < countBuckets; i++)
            {
                if (buckets[i].GetHashCode() == key.GetHashCode())
                    return true;
            }
            return false;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private void Resize()
        {
            if (items.Length == countItems)
                Array.Resize(ref items, items.Length * 2);
            if (buckets.Length == countBuckets)
                Array.Resize(ref buckets, buckets.Length * 2);

        }
    }
}
