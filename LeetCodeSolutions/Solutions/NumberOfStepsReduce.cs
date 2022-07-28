using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class NumberOfStepsReduce
    {
        public int NumberOfSteps(int num)
        {
            int length = 0;

            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num--;
                }

                length++;
            }

            return length;
        }
    }
}
