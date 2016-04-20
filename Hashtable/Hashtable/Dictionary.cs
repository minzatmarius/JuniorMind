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
        public struct Entry
        {
            public TKey key;
            public TValue value;
            public int previous;
            public Entry(TKey key, TValue value, int previous)
            {
                this.key = key;
                this.value = value;
                this.previous = previous;
            }
        }

        public Entry[] entries = new Entry[8]; 
        private int countBuckets;
        private int countEntries;
       
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
                return countEntries;
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
            Add(item.Key, item.Value);
        }

        public void Add(TKey key, TValue value)
        {
            Resize();
            int index = GetIndex(key);
            int previous = buckets[index];
            entries[countEntries + 1] = new Entry(key, value, previous);
            buckets[index] = ++countEntries;
        }

        public void Clear()
        {
            buckets = new int[8];
            entries = new Entry[8];
            countBuckets = 0;
            countEntries = 0;
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return ContainsKey(item.Key);
        }

        public bool ContainsKey(TKey key)
        {
            return buckets[GetIndex(key)] != 0;
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
            if (entries.Length == countEntries)
                Array.Resize(ref entries, entries.Length * 2);
            if (buckets.Length == countBuckets)
                Array.Resize(ref buckets, buckets.Length * 2);

        }

        private int GetIndex(TKey key)
        {
            return key.GetHashCode() % buckets.Length;
        }
    }
}
