using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class LRUCache
    {
        int capacity = 0;
        LinkedList<int> cache = new LinkedList<int>();
        Dictionary<int, (LinkedListNode<int>, int)> keys = new Dictionary<int, (LinkedListNode<int>, int)>();

        private 
        LRUCache(int capacity)
        {
            this.capacity = capacity;
            cache = new LinkedList<int>();
            keys = new Dictionary<int, (LinkedListNode<int>, int)>();
        }

        public int Get(int key)
        {
            if (keys.ContainsKey(key))
            {
                LinkedListNode<int> reshuffleNode = keys[key].Item1;
                cache.Remove(reshuffleNode);
                cache.AddLast(reshuffleNode);
                return keys[key].Item2;
            }
            
            return -1;
        }

        public void Put(int key, int value)
        {
            if (!keys.ContainsKey(key))
            {
                LinkedListNode<int> newNode = cache.AddLast(key);
                keys.Add(key, (newNode, value));

                if (keys.Count > capacity)
                {
                    LinkedListNode<int> removedNode = cache.First;
                    cache.RemoveFirst();
                    keys.Remove(removedNode.Value);
                }
            }
            else
            {
                LinkedListNode<int> reshuffleNode = keys[key].Item1;
                keys[key] = (reshuffleNode, value);
                cache.Remove(reshuffleNode);
                cache.AddLast(reshuffleNode);
            }
        }
    }
}
