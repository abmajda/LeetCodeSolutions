using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class MeetingRooms2
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            List<int[]> currentMeetings = new List<int[]>();
            int maxRooms = 0;
            // sort by start time
            int[][] timing = intervals;
            Array.Sort(timing, (x, y) => x[0].CompareTo(y[0]));

            // take each input
            foreach (int[] time in timing)
            {
                // remove expired meetings
                List<int[]> removingMeetings = new List<int[]>();
                foreach (int[] meetingTime in currentMeetings)
                {
                    if (time[0] >= meetingTime[1])
                    {
                        removingMeetings.Add(meetingTime);
                    }
                }

                foreach (int[] meetingToDelete in removingMeetings)
                {
                    currentMeetings.Remove(meetingToDelete);
                }

                // add the meeting
                currentMeetings.Add(time);

                // if size of structure is more than current max, replace
                int currentSize = currentMeetings.Count;

                if (currentSize > maxRooms)
                {
                    maxRooms = currentSize;
                }
            }

            // return max size of structure
            return maxRooms;
        }
    }
}
