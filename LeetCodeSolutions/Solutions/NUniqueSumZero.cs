using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class NUniqueSumZero
    {
        public int[] SumZero(int n)
        {
            int[] uniqueNums = new int[n];
            int evenn = n;
            bool odd = false;

            if (n % 2 == 1)
            {
                odd = true;
            }

            if (odd)
            {
                evenn--;
            }

            for (int i = 0; i < evenn; i = i + 2)
            {
                uniqueNums[i] = 0 - i - 1;
                uniqueNums[i + 1] = i + 1;
            }

            if (odd)
            {
                uniqueNums[n - 1] = 0;
            }

            return uniqueNums;
        }
    }
}
