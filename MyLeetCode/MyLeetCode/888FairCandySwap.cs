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
        public int DaysBetweenDates(string date1, string date2)
        {
            System.DateTime dt1 = System.Convert.ToDateTime(date1);
            System.DateTime dt2 = System.Convert.ToDateTime(date2);
            return System.Math.Abs((int)(dt2 - dt1).TotalDays);
        }

        //   public int leftMostColumnWithOne(BinaryMatrix binaryMatrix) {
        //     int rows = binaryMatrix.Dimensions()[0];
        //     int cols = binaryMatrix.Dimensions()[1];
        //      // Set pointers to the top-right corner.
        //     int currentRow = 0;
        //     int currentCol = cols - 1;
        //      // Repeat the search until it goes off the grid.
        //     while (currentRow < rows && currentCol >= 0) {
        //       if (binaryMatrix.get(currentRow, currentCol) == 0) {
        //         currentRow++;
        //       } else {
        //         currentCol--; 
        //       }
        //     }
        //     // If we never left the last column, this is because it was all 0's.
        //     return (currentCol == cols - 1) ? -1 : currentCol + 1;
        //   }


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