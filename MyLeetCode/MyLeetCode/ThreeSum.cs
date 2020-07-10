using System;
using System.Collections.Generic;
namespace Leetcode
{
    public class ThreeSum
    {
        private const int V = 0;

        // public static void Main()
        // {
        //         // int[] A = new int[4] { -2, -1, 2, 1 };
        //         // Console.WriteLine(MaxSubArrayLen(A, 1));
        //         // Console.WriteLine("For the string {0} value is {1}", s, LongestSubstringKDistinct(s, 3));
        //         // Console.WriteLine("For the string {0} value is {1}", "araaci", LongestSubstringKDistinct("araaci", 2));
        //         // Console.WriteLine("For the string {0} value is {1}", "araaci", LongestSubstringKDistinct("araaci", 1));
        //         // Console.WriteLine("For the string {0} for k={1} result is {2}", "eceba", 2, LongestSubstringKDistinct("eceba", 2));

        //         // Console.WriteLine("For the string {0} for k={1} result is {2}", "aa", 1, LongestSubstringKDistinct("aa", 1));
        //         //Console.WriteLine("For the string {0} for k={1} result is {2} expected is 1", "a", 2, LongestSubstringKDistinct("a", 2));
        //         Console.WriteLine(" TotalFruit {0}", TotalFruit(new int[] { 0, 1, 2, 2 }));

        //Console.WriteLine("Threesum for the given array [-2,0,1,1,2]");
        //IList<IList<int>> lists = ThreeSum1(new int[] { -1, 0, 1, 2, -1, -4 });
        // IList<IList<int>> lists = ThreeSum1(new int[] { -2, 0, 1, 1, 2 });
        // foreach (var list in lists)
        // {
        //     foreach (var i in list)
        //     {
        //         Console.Write(i);
        //     }
        //     Console.WriteLine("\n");
        // }

        // Console.WriteLine("Threesum for the given array [-1, 0, 1, 2, -1, -4]");
        // IList<IList<int>> lists1 = ThreeSum1(new int[] { -1, 0, 1, 2, -1, -4 });
        // foreach (var list in lists1)
        // {
        //     foreach (var i in list)
        //     {
        //         Console.Write(i);
        //     }
        //     Console.WriteLine("\n");
        // }


        //     Console.WriteLine("Threesum for the given array [0,0]");
        //     IList<IList<int>> lists2 = ThreeSum1(new int[] { 0 });
        //     IList<IList<int>> lists3 = threeSum(new int[] { 0 });
        //     IList<IList<int>> lists = new List<IList<int>>();
        //     Console.WriteLine(lists);

        // }
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
        public static int TotalFruit(int[] tree)
        {
            if (tree == null || tree.Length == 0)
                return 0;

            int windowStart = 0, maxLength = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            HashSet<int> set = new HashSet<int>();
            for (int windowEnd = 0; windowEnd < tree.Length; windowEnd++)
            {
                if (map.ContainsKey(tree[windowEnd]))
                    map[tree[windowEnd]] = map.GetValueOrDefault(tree[windowEnd], 0) + 1;
                else
                    map.Add(tree[windowEnd], 1);

                if (!set.Contains(tree[windowEnd]))
                {
                    set.Add(tree[windowEnd]);
                }

                while (set.Count > 2 && windowStart < tree.Length)
                {
                    if (map.ContainsKey(tree[windowStart]))
                        map[tree[windowStart]] = map.GetValueOrDefault(tree[windowStart], 0) - 1;
                    else
                        map.Add(tree[windowStart], 1);

                    if (map[tree[windowStart]] == 0)
                    {
                        map.Remove(tree[windowStart]);
                        set.Remove(tree[windowStart]);
                    }
                    windowStart++;
                }
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }

            return maxLength;
        }

        //[-1,0,1,2,-1,-4]
        public static bool isZeroArray(int[] nums)
        {
            bool result = false;
            foreach (var i in nums)
            {
                if (i != 0)
                {
                    result = false;
                }
            }
            return result;
        }
        public static IList<IList<int>> ThreeSum1(int[] nums)
        {
            bool isEmpty = false;
            foreach (var i in nums)
            {
                if (i == 0)
                    isEmpty = true;

                else
                    isEmpty = false;
            }
            IList<IList<int>> lists = new List<IList<int>>();

            if (isEmpty)
            {
                lists.Add(new List<int>());
                return lists;
            }




            int start = 0, end = 0;
            Array.Sort(nums);


            for (int i = 0; i < nums.Length; i++)
            {
                //start = i + 1;
                start = i;
                end = nums.Length - 1;
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                while (start < end)
                {
                    // if (end < nums.Length - 1 && nums[end] == nums[end - 1])
                    // {
                    //     end--;
                    //     continue;
                    // }
                    if (nums[i] + nums[start] + nums[end] == 0)
                    {
                        //return the 
                        lists.Add(new List<int> { nums[i], nums[start], nums[end] });
                        start++; end--;
                    }
                    else if (nums[i] + nums[start] + nums[end] < 0)
                    {
                        //increment start
                        start++;
                    }
                    else if (nums[i] + nums[start] + nums[end] > 0)
                    {
                        //increment start
                        end--;
                    }
                }
                Console.WriteLine("Print i={0}", i);
            }
            return lists;
        }

        public static IList<IList<int>> threeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < nums.Length && nums[i] <= 0; ++i)
                if (i == 0 || nums[i - 1] != nums[i])
                    twoSumII(nums, i, res);
            return res;
        }
        static void twoSumII(int[] nums, int i, IList<IList<int>> res)
        {
            int lo = i + 1, hi = nums.Length - 1;
            while (lo < hi)
            {
                int sum = nums[i] + nums[lo] + nums[hi];
                if (sum < 0 || (lo > i + 1 && nums[lo] == nums[lo - 1]))
                    ++lo;
                else if (sum > 0 || (hi < nums.Length - 1 && nums[hi] == nums[hi + 1]))
                    --hi;
                else
                    res.Add(new List<int> { nums[i], nums[lo++], nums[hi--] });
            }
        }
    }
}

