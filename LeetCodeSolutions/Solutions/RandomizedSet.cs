using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class RandomizedSet
    {
        private Dictionary<int, int> randomizedSet;
        private List<int> list;
        Random randomNumberGenerator;

        public RandomizedSet()
        {
            randomizedSet = new Dictionary<int, int>();
            list = new List<int>();
            randomNumberGenerator = new Random();
        }

        public bool Insert(int val)
        {
            if (randomizedSet.ContainsKey(val))
            {
                return false;
            }
            else
            {
                list.Add(val);
                randomizedSet.Add(val, list.Count - 1);
            }

            return true;
        }

        public bool Remove(int val)
        {
            if (!randomizedSet.ContainsKey(val))
            {
                return false;
            }
            else
            {
                int index = randomizedSet[val];
                
                // get list at end
                int endOfList = list[list.Count - 1];

                // update end value
                randomizedSet[endOfList] = randomizedSet[val]; ;

                // swap in list
                list[index] = list[list.Count - 1];

                // remove from both
                list.RemoveAt(list.Count - 1);
                randomizedSet.Remove(val);
            }

            return true;
        }

        public int GetRandom()
        {
            int index = randomNumberGenerator.Next(list.Count);
            return list[index];
        }
    }
}
