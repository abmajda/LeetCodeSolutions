using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class GroupedAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> combos = new List<IList<string>>();

            foreach (string str in strs)
            {
                bool found = false;

                foreach (IList<string> group in combos)
                {
                    // handle the handling for the group
                    string firstString = group[0];

                    if (firstString.Length == str.Length)
                    {
                        string strCopy = str;
                        foreach (char letter in firstString)
                        {
                            int index = strCopy.IndexOf(letter);

                            if (index == -1)
                            {
                                break;
                            }
                            else
                            {
                                strCopy = strCopy.Remove(index, 1);
                            }
                        }

                        Console.WriteLine(strCopy.Length);

                        if (strCopy.Length == 0)
                        {
                            found = true;
                            group.Add(str);
                            break;
                        }
                    }
                }

                if (!found)
                {
                    combos.Add(new List<string> { str });
                }
            }

            return combos;
        }
    }
}
