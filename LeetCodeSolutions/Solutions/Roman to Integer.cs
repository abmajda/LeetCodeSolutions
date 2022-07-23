using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class RomanToIntSolution
    {
        public int RomanToInt(string s)
        {
            int finalResult = 0;
            int previousValue = 0;
            int convertedValue = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                ConvertRoman.TryGetValue(s[i], out int converted);
                previousValue = convertedValue;
                convertedValue = converted;

                // compare to earlier number and subtract if larger
                if (convertedValue < previousValue)
                {
                    finalResult -= convertedValue;
                } 
                else
                {
                    finalResult += convertedValue;
                }
            }

            return finalResult;
        }

        private Dictionary<char, int> ConvertRoman = new() {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };
    }
}
