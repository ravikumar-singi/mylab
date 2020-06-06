using System.Collections.Generic;
using System.Linq;

namespace MyLeetCode
{
    class PlusOne
    {
        public int[] PlusOneMethod(int[] digits)
        {
            int n = digits.Length;
            int carry = 1;
            List<int> lst = new List<int>();
            int i = n;
            while (--i >= 0 || carry > 0)
            {
                if (i >= 0)
                    carry += digits[i];
                lst.Add(carry % 10);
                carry /= 10;
            }
            lst.Reverse();
            return lst.ToArray<int>();
        }
    }
}
