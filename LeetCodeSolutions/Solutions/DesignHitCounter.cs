using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class HitCounter
    {
        private Queue<int> hits;

        public HitCounter()
        {
            this.hits = new Queue<int>();
        }

        public void Hit(int timestamp)
        {
            this.hits.Enqueue(timestamp);
        }

        public int GetHits(int timestamp)
        {

            while (this.hits.Count != 0 && this.hits.Peek() <= timestamp - 300)
            {
                this.hits.Dequeue();
            }

            return this.hits.Count;
        }
    }
}
