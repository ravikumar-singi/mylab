public class MaxConsecutiveOnes
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int windCount = 0, maxCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
                windCount++;
            else
            {
                maxCount = System.Math.Max(maxCount, windCount);
                windCount = 0;
            }
        }
        return System.Math.Max(maxCount, windCount);
    }

    // Input: [1,0,1,1,0]
    // Output: 4
    // Explanation: Flip the first zero will get the the maximum number of consecutive 1s. After flipping, the maximum number of consecutive 1s is 4.

    public int FindMaxConsecutiveOnesPart2(int[] nums)
    {

    }
}