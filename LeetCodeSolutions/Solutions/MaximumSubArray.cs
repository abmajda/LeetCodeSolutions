using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class MaximumSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = Int32.MinValue;

            int globalMax = 0;
            int localMax = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                globalMax += nums[i];
                localMax += nums[i];

                if (localMax > maxSum)
                {
                    maxSum = localMax;
                }

                if (globalMax <= 0)
                {
                    localMax = 0;
                    globalMax = 0;
                }
            }

            return maxSum;
        }
    }
}
