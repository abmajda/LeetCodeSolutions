using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> ransomHash = new Dictionary<char, int>();

            foreach (char letter in magazine)
            {
                ransomHash[letter] = (ransomHash.ContainsKey(letter)) ? ransomHash[letter] + 1 : 1;
            }

            foreach (char letter in ransomNote)
            {
                if (ransomHash.ContainsKey(letter) && ransomHash[letter] > 0)
                {
                    ransomHash[letter]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
