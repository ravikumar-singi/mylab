using System;
using System.Collections.Generic;
namespace mylab
{
    private static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i };
            }
            else
            {
                if (!numMap.ContainsKey(nums[i]))
                    numMap.Add(nums[i], i);
            }
        }
        return new int[] { };
    }
}