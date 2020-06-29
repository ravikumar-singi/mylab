using System;
namespace myleetcode
{
    public class HelloWorld
    {
        // static void Main()
        // {
        //     System.Console.WriteLine("Hello World!");
        //     int[] A = new int[6] { 2, 1, 5, 1, 3, 2 };
        //     int k = 3;
        //     Console.WriteLine(MaxSlidingWindow(A, k));

        // }
        public static int MaxSlidingWindow(int[] nums, int k)
        {
            int winSum = 0, maxSum = 0, startIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                winSum = winSum + nums[i];

                if (i >= k - 1)
                {
                    maxSum = System.Math.Max(winSum, maxSum);
                    winSum = winSum - nums[startIndex];
                    startIndex++;
                }
            }
            return maxSum;
        }
    }
}