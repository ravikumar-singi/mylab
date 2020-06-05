using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCode
{
    public class ReverseInteger
    {
        public long Reverse(long x)
        {
            long given = x;
            long sign = Math.Sign(x);
            x=Math.Abs(x);
            long y =0;
            long z = 0;
           
                while (x > 0)
                {
                    y = x % 10;
                    z = (z * 10) + y;
                    x = x / 10;
                }

            //if (x < 10)
            //{
            //    z = (z * 10) + y;
            //}

            if (sign<0)
                return -z;
            else
                return z;
        }

        public int Java_Reverse(int x)
        {
            long res = 0;
            while (x != 0)
            {
                res = res * 10 + x % 10;
                x = x / 10;
            }

            if (res < int.MinValue || res > int.MaxValue)
            {
                return 0;
            }
            else
            {
                return (int)res;
            }
        }
    }
}
