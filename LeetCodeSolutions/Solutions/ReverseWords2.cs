using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class ReverseWords2
    {
        public void ReverseWords(char[] s)
        {
            Array.Reverse(s, 0, s.Length);

            // go through each word and rewap

            int start = 0;
            int end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || i == s.Length - 1)
                {
                    end = i;

                    // handle the fact there is no space after
                    if (i == s.Length - 1)
                    {
                        end++;
                    }

                    Array.Reverse(s, start, (end - start));
                    start = i + 1;
                }
            }
        }
    }
}
