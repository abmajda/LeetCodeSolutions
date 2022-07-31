using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class RemoveDigitMaximize
    {
        public string RemoveDigit(string number, char digit)
        {
            bool firstTime = true;
            string topString = "";
            string newString = "";

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == digit)
                {
                    if (firstTime)
                    {
                        firstTime = false;
                        topString = number.Remove(i, 1);
                    }
                    else
                    {
                        newString = number.Remove(i, 1);

                        for (int j = 0; j < newString.Length; j++)
                        {
                            if (newString[j] > topString[j])
                            {
                                topString = newString;
                                break;
                            }
                            else if (topString[j] > newString[j])
                            {
                                break;
                            }
                        }
                    }
                }
            }

            return topString;
        }
    }
}
