using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class SignOfArray
    {
        public int ArraySign(int[] nums)
        {
            var result = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                int simplified = 0;
                if (nums[i] == 0)
                {
                    return 0;
                }
                else if (nums[i] > 0)
                {
                    simplified = 1;
                }
                else
                {
                    simplified = -1;
                }
                result *= simplified;
            }

            if (result > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
