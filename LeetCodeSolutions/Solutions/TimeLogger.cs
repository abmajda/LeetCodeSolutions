using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class TimeLogger
    {
        public TimeLogger()
        {
            timeouts = new Dictionary<string, int> ();
        }

        public bool ShouldPrintMessage(int timestamp, string message)
        {
            int value = 0;

            if (timeouts.ContainsKey(message)) 
            { 
                value = timeouts[message];

                if (value <= timestamp)
                {
                    timeouts[message] = timestamp + 10;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                timeouts.Add(message, timestamp + 10);
                return true;
            }
        }

        private Dictionary<string, int> timeouts;
    }
}
