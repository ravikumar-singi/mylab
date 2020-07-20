using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System;

namespace myleetcode
{
    class AddBinary
    {
        public string AddBinaryMethod(string a, string b)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int i = a.Length - 1, j = b.Length - 1, carry = 0;
            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (j >= 0)
                    sum += b[j--] - '0';
                if (i >= 0)
                    sum += a[i--] - '0';
                sb.Append(sum % 2);
                carry = sum / 2;
            }
            if (carry != 0)
                sb.Append(carry);
            return new string(sb.ToString().Reverse().ToArray());
        }

        public string AddBin(string a, string b)
        {
            string s = Convert.ToString(
                Convert.ToInt32(
                    (Convert.ToInt32("11", 2) + Convert.ToInt32("1", 2)).ToString(), 2)
                    );
            return s;
        }
    }
}
