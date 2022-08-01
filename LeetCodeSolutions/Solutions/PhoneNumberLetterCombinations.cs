using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class PhoneNumberLetterCombinations
    {
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> list = new List<string>();

            if (digits.Length == 0)
            {
                // do nothing
            }
            else if (digits.Length == 1)
            {
                list = resolveButton(digits[0]);
            }
            else
            {
                list = findPossibilities(digits);
            }

            return list;
        }

        private List<string> findPossibilities(string remaningDigits)
        {
            char digit = remaningDigits[0];
            List<string> finalPossibilities = new List<string>();
            List<string> letterCombinations = resolveButton(digit);

            if (remaningDigits.Length == 1)
            {
                foreach (string letter in letterCombinations)
                {
                    finalPossibilities.Add(letter);
                }
            }
            else
            {
                string newDigits = remaningDigits.Substring(1);

                foreach (string letter in letterCombinations)
                {
                    List<string> returnedPossibilites = findPossibilities(newDigits);

                    // add the current digit to each and put in final possibilities
                    for (int i = 0; i < returnedPossibilites.Count; i++)
                    {
                        returnedPossibilites[i] = letter.ToString() + returnedPossibilites[i];
                    }

                    finalPossibilities.AddRange(returnedPossibilites);
                }
            }
           

            // return the final possibilities
            return finalPossibilities;
        }

        private List<string> resolveButton(char digit)
        {
            List<string> result = new List<string>();

            switch (digit)
            {
                case '2':
                    result.Add("a");
                    result.Add("b");
                    result.Add("c");
                    break;
                case '3':
                    result.Add("d");
                    result.Add("e");
                    result.Add("f");
                    break;
                case '4':
                    result.Add("g");
                    result.Add("h");
                    result.Add("i");
                    break;
                case '5':
                    result.Add("j");
                    result.Add("k");
                    result.Add("l");
                    break;
                case '6':
                    result.Add("m");
                    result.Add("n");
                    result.Add("o");
                    break;
                case '7':
                    result.Add("p");
                    result.Add("q");
                    result.Add("r");
                    result.Add("s");
                    break;
                case '8':
                    result.Add("t");
                    result.Add("u");
                    result.Add("v");
                    break;
                default:
                    result.Add("w");
                    result.Add("x");
                    result.Add("y");
                    result.Add("z");
                    break;
            }

            return result;
        }
    }
}
