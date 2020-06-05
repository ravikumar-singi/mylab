using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseInteger rv = new ReverseInteger();
           // long a = rv.Reverse(1534236469);
            int ab = rv.Java_Reverse(-134236469);
            Trace.WriteLine(ab);
            //Console.ReadKey();
        }
    }
}
