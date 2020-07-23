using System.Collections.Generic;

namespace Leetcode
{
    public class Solution
    {
        // public static void Main()
        // {
        //     int[] A = new int[] { 1, 1 };
        //     int[] B = new int[] { 2, 2 };
        //     FairCandySwap(A, B);
        // }

        public static int[] FairCandySwap(int[] A, int[] B)
        {
            int ATotal = 0, BTotal = 0;

            for (int i = 0; i < A.Length; i++)
            {
                ATotal = ATotal + A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                BTotal = BTotal + B[i];
            }

            int delta = (BTotal - ATotal) / 2;
            HashSet<int> setB = new HashSet<int>();
            foreach (var x in B)
            {
                setB.Add(x);
            }

            foreach (var x in A)
            {
                if (setB.Contains(x + delta))
                {
                    System.Console.WriteLine("Both the nos are {0},{1}", x, x + delta);
                    return new int[] { x, x + delta };
                }
            }
            System.Console.WriteLine("Both the nos are {0},{1}", 0, 0);
            return new int[] { };
        }
    }
}