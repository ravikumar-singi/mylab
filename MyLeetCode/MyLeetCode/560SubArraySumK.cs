using System;
namespace myleetcode
{
    public class SubArraySum
    {
        // public static void Main()
        // {
        //     System.Console.WriteLine("Hello World!");
        //     int[] A = new int[6] { 2, 3, 1, 2, 4, 3 };
        //     int k = 7;
        //     Console.WriteLine(MinSubArrayLen(k, A));

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

        // public static int ShortestSubarray(int[] A, int K)
        // {
        //     int winSum = 0, maxSum = 0, ShortestSubarraySize = 0, startIndex = 0, endIndex = 0;
        //     for (int i = 0; i < A.Length; i++)
        //     {
        //         winSum = winSum + A[i];
        //         maxSum = System.Math.Max(winSum, maxSum);
        //         if (maxSum >= K)
        //         {
        //             winSum = winSum - A[startIndex];
        //             startIndex++;
        //         }
        //     }
        //     return maxSum;
        // }
        public static int MinSubArrayLen(int s, int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int winSum = 0, startIndex = 0, endIndex = 0, minWindowSize = int.MaxValue;
            while (endIndex < nums.Length)
            {
                winSum = winSum + nums[endIndex++];
                while (winSum >= s)//If windowsize is more than the s then srink the window
                {
                    minWindowSize = System.Math.Min(minWindowSize, endIndex - startIndex);
                    winSum = winSum - nums[startIndex++];
                }
            }
            return minWindowSize == int.MaxValue ? 0 : minWindowSize;
        }
    }
}