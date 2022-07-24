using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class Palindrome_Linked_List
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
        public bool IsPalindrome(ListNode head)
        {
            // first find the length
            int listLength = 1;
            ListNode lengthScanner = head;

            while (lengthScanner.next != null)
            {
                listLength++;
                lengthScanner = lengthScanner.next;
            }

            // get the middle and set up a odd flag to handle odd values
            bool odd = false;
            if (listLength % 2 == 1)
            {
                odd = true;
            }
            int middleLength = listLength / 2;
            if (odd)
            {
                middleLength++;
            }

            // then run through the first half to fill the stack
            Stack<int> numbers = new Stack<int>();
            ListNode pass = head;

            for (int i = 0; i < middleLength; i++)
            {
                numbers.Push(pass.val);
                pass = pass.next;
            }

            // run through the next stack popping matches, handle odd values first
            if (odd)
            {
                numbers.Pop();
            }

            for (int i = middleLength; i < listLength; i++)
            {
                if (pass.val == numbers.Pop())
                {
                    pass = pass.next;
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
