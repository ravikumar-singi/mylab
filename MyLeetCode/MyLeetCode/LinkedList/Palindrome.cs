

using System;
using System.Collections.Generic;
using System.Text;

namespace myleetcode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Palidrome
    {
        public bool IsPalindrome(ListNode head)
        {
            List<int> vals = new List<int>();

            ListNode currentNode = head;
            while (currentNode != null)
            {
                vals.Add(currentNode.val);
                currentNode = currentNode.next;
            }

            int front = 0;
            int back = vals.Count - 1;
            while (front < back)
            {
                if (vals[front] != vals[back])
                {
                    return false;
                }
                front++;
                back--;
            }
            return true;
        }

        public bool IsPalindrome(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i])) stringBuilder.Append(s[i]);
            }
            string finalstring = stringBuilder.ToString().ToLower();
            char[] charArray = finalstring.ToCharArray();
            Array.Reverse(charArray);
            string reverseString = new string(charArray);

            if (finalstring.Equals(reverseString)) return true;
            else return false;
        }
        // public string Reverse(string s)
        // {
        //     char[] charArray = s.ToCharArray();
        //     Array.Reverse(charArray);
        //     return new string(charArray);
        // }

        // public bool IsPalindrome(int x)
        // {
        //     char[] characters = x.ToString().ToCharArray();
        //     for (int i = 0; i < characters.Length / 2; i++)
        //     {
        //         if (characters[i] != characters[characters.Length - i - 1])
        //         {
        //             return false;
        //         }
        //     }
        //     return true;
        // }
        public bool ValidPalindrome2(string s)
        {
            int l = -1, r = s.Length;
            while (++l < --r)
                if (s[l] != s[r]) return isPalindromic(s, l, r + 1) || isPalindromic(s, l - 1, r);
            return true;
        }
        public bool isPalindromic(String s, int l, int r)
        {
            while (++l < --r)
                if (s[l] != s[r]) return false;
            return true;
        }
    }

}