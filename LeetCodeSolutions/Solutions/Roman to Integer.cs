﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class RomanToIntSolution
    {
        public int RomanToInt(string s)
        {
            int[] convertedNums = new int[s.Length];
            int finalResult = 0;

            for (int i = 0; i < s.Length; i++)
            {

            }

            return finalResult;
        }

        private int ConvertRoman(char romanChar)
        {
            switch (romanChar)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    throw new Exception("invalid char");
            }
        }
    }
}
