using System.Collections.Generic;

namespace MyLeetCode
{
    class AddtoArrayFormofInteger
    {
        public IList<int> AddToArrayForm(int[] A, int K)
        {
            int n = A.Length;
            int carry = K;
            List<int> lst = new List<int>();
            int i = n;
            while (--i >= 0 || carry > 0)
            {
                if (i >= 0)
                    carry += A[i];
                lst.Add(carry % 10);
                carry /= 10;
            }
            lst.Reverse();
            return lst;
        }
    }
}
