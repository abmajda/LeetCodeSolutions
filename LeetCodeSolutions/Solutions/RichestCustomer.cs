using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class RichestCustomer
    {
        public int MaximumWealth(int[][] accounts)
        {
            int highest = 0;

            for (int i = 0; i < accounts.Length; i++)
            {

                int accountTotal = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    accountTotal += accounts[i][j];
                }

                if (accountTotal > highest)
                {
                    highest = accountTotal;
                }
            }

            return highest;
        }
    }
}
