using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class MiddleLinkedList
    {
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int val=0, ListNode next=null) {
         *         this.val = val;
         *         this.next = next;
         *     }
         * }
         */
        public class Solution
        {
            public ListNode MiddleNode(ListNode head)
            {
                ListNode firstPass = head;
                ListNode middlePass = head;
                double length = 0.0;

                while (firstPass.next != null)
                {
                    firstPass = firstPass.next;
                    length++;
                }

                int midpoint = (int)Math.Ceiling(length / 2);

                for (int i = 0; i < midpoint; i++)
                {
                    middlePass = middlePass.next;
                }

                return middlePass;
            }
        }
    }
}
