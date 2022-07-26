using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class FizzBuzz
    {
        public IList<string> Display(int n)
        {
            IList<string> list = new List<string>();

            for (int i = 1; i < n + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }

            return list;
        }
    }
}
