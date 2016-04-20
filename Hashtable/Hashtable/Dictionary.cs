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
                return entries[buckets[GetIndex(key)]].value;
            }

            set
            {
                entries[buckets[GetIndex(key)]].value = value;
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
            entries[FirstEmptySlot()] = new Entry(key, value, previous);
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
            int j = 1;
            int end = Math.Min(array.Length, countEntries + arrayIndex + 1);
            for (int i = arrayIndex; i < end; i++)
            {
                array[i] = new KeyValuePair<TKey, TValue>(entries[j].key, entries[j].value);
                j++;
            }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < countEntries + 1; i++)
            {
                TKey key = entries[i].key;
                TValue value = entries[i].value;
                if (!entries[i].Equals(default(Entry)))
                {
                    yield return new KeyValuePair<TKey, TValue>(key, value);
                }
            }
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return Remove(item.Key);
        }

        public bool Remove(TKey key)
        {
            RemoveEntries(key);
            buckets[GetIndex(key)] = 0;
            return buckets[GetIndex(key)] == 0;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            /*
                        while (currentPosition != 0)
                        {
                            if (entries[currentPosition].Equals(value)) return true;
                            currentPosition = entries[currentPosition].previous;
                        }
            */

            throw new NotImplementedException();


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void Resize()
        {
            if (entries.Length == countEntries)
                Array.Resize(ref entries, entries.Length * 2);
            if (buckets.Length == countBuckets)
                Array.Resize(ref buckets, buckets.Length * 2);

        }

        private void RemoveEntries(TKey key)
        {
            int currentPosition = buckets[GetIndex(key)];
            while (currentPosition != 0)
            {
                int previousPosition = entries[currentPosition].previous;
                entries[currentPosition] = default(Entry);
                currentPosition = previousPosition;
            }
        }

        private int FirstEmptySlot()
        {
            for (int i = 1; i < entries.Length; i++)
            {
                if (entries[i].Equals(default(Entry))) return i;
            }
            return entries.Length + 1;
        }

        private int GetIndex(TKey key)
        {
            return key.GetHashCode() % buckets.Length;
        }
    }
}
