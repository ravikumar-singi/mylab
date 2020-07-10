using System;
using System.Collections;

namespace Leetcode
{
    public class ValidParanthesis
    {
        public static void Main()
        {
            string s = "()[]{[}";
            Console.WriteLine("Given expression{0},{1}", s, IsValid(s));
        }
        public static bool IsValid(string s)
        {
            var sck = new Stack();
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (ch == '(')
                    sck.Push(')');
                else if (ch == '{')
                    sck.Push('}');
                else if (ch == '[')
                    sck.Push(']');
                else if (sck.Count == 0 || !sck.Pop().Equals(ch))
                    return false;
            }
            return sck.Count == 0;
        }
    }
}