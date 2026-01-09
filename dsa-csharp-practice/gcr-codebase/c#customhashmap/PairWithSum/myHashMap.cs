using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.CustomHashmap.PairWithSum
{
    public class myHashMap<K, V>
    {

        public class Node
        {
            public K Key;
            public V Value;
            public Node Next;

            public Node(K key, V value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

        private int capacity = 100;
        private Node[] buckets;

        public myHashMap()
        {
            buckets = new Node[capacity];
        }

        private int GetBucketIndex(K key)
        {
            int hashCode = key.GetHashCode();
            int index = hashCode % capacity;
            return Math.Abs(index);
        }

        public void Put(K key, V value)
        {
            int index = GetBucketIndex(key);
            Node head = buckets[index];
            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    head.Value = value;
                    return;
                }
                head = head.Next;
            }
            Node newNode = new Node(key, value);
            newNode.Next = buckets[index];
            buckets[index] = newNode;
        }

        public bool ContainsKey(K key)
        {
            int index = GetBucketIndex(key);
            Node head = buckets[index];
            while (head != null)
            {
                if (head.Key.Equals(key)) return true;
                head = head.Next;
            }
            return false;
        }


        public bool CheckPair(int[] arr, int target)
        {
            myHashMap<int, int> map = new myHashMap<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                if (map.ContainsKey(complement))
                {
                    return true;
                }
                map.Put(arr[i], 1);
            }
            return false;
        }
    }
}

