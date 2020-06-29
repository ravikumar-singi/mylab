using System;
using System.Collections.Generic;
namespace Leetcode
{
    public class ThreeSum
    {
        public static void Main()
        {
            // int[] A = new int[4] { -2, -1, 2, 1 };
            // Console.WriteLine(MaxSubArrayLen(A, 1));
            string s = "cbbebi";
            // Console.WriteLine("For the string {0} value is {1}", s, LongestSubstringKDistinct(s, 3));
            // Console.WriteLine("For the string {0} value is {1}", "araaci", LongestSubstringKDistinct("araaci", 2));
            // Console.WriteLine("For the string {0} value is {1}", "araaci", LongestSubstringKDistinct("araaci", 1));
            // Console.WriteLine("For the string {0} for k={1} result is {2}", "eceba", 2, LongestSubstringKDistinct("eceba", 2));

            // Console.WriteLine("For the string {0} for k={1} result is {2}", "aa", 1, LongestSubstringKDistinct("aa", 1));
            Console.WriteLine("For the string {0} for k={1} result is {2} expected is 1", "a", 2, LongestSubstringKDistinct("a", 2));
        }
        public static IList<IList<int>> ThreeSumMethod(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            int[] twosum;
            for (int i = 0; i < nums.Length; i++)
            {
                twosum = TwoSum(nums, -nums[i]);
                if (twosum != null && twosum.Length > 1)
                {
                    if (nums[i] + twosum[0] + twosum[1] == 0)
                    {
                        result.Add(new List<int> { nums[i], twosum[0], twosum[1] });
                    }

                }
            }
            return (IList<IList<int>>)result;
        }
        public static int[] TwoSum(int[] nums, int target)
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

        public static int MaxSubArrayLen(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0) return 0;
            int sum = 0, max = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                if (sum == k) max = i + 1;
                else if (map.ContainsKey(sum - k)) max = Math.Max(max, i - map.GetValueOrDefault(sum - k));
                if (!map.ContainsKey(sum))
                    map.Add(sum, i);
            }
            return max;
        }

        public static int LongestSubstringwithAtLeastKcharacters(string s, int k)
        {
            if (s == null || s.Length == 0) return 0;
            int start = 0, maxLen = 0;
            char c;
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                c = s[i];
                if (map.ContainsKey(c))
                    map[c] = map.GetValueOrDefault(c) + 1;
                else
                    map.Add(c, 1);


                while (map.Count > k)//strink the sliding window
                {
                    map[s[start]] = map.GetValueOrDefault(s[start]) - 1;
                    if (map.GetValueOrDefault(s[start]) == 0) map.Remove(s[start]);
                }
                maxLen = Math.Max(maxLen, i - start + 1);
            }
            return maxLen;
        }

        public static int LongestSubstringKDistinct(string s, int k)
        {
            if (s == null || s.Length == 0)
                return 0;

            int windowStart = 0, maxLength = 0;
            Dictionary<char, int> charFrequencyMap = new Dictionary<char, int>();
            // in the following loop we'll try to extend the range [windowStart, windowEnd]
            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                char rightChar = s[windowEnd];

                if (charFrequencyMap.ContainsKey(rightChar))
                    charFrequencyMap[rightChar] = charFrequencyMap.GetValueOrDefault(rightChar, 0) + 1;
                else
                    charFrequencyMap.Add(rightChar, 1);
                // shrink the sliding window, until we are left with 'k' distinct characters in the frequency map
                while (charFrequencyMap.Count > k && windowStart < s.Length)
                {
                    char leftChar = s[windowStart];
                    if (charFrequencyMap.ContainsKey(leftChar))
                        charFrequencyMap[leftChar] = charFrequencyMap.GetValueOrDefault(leftChar, 0) - 1;
                    else
                        charFrequencyMap.Add(leftChar, 1);

                    if (charFrequencyMap[leftChar] == 0)
                    {
                        charFrequencyMap.Remove(leftChar);
                    }
                    windowStart++;
                }
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }

            return maxLength;
        }
    }

}

