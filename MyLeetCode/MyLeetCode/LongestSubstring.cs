using System;
using System.Collections.Generic;
namespace Leetcode
{
    //395. Longest Substring with At Least K Repeating Characters
    // Input:
    // s = "aaabb", k = 3
    // Output:
    // 3
    // The longest substring is "aaa", as 'a' is repeated 3 times.

    // Input:
    // s = "ababbc", k = 2
    // Output:
    // 5
    // The longest substring is "ababb", as 'a' is repeated 2 times and 'b' is repeated 3 times.

    public class LongestSubstring
    {
        // public static void Main()
        // {
        //Console.WriteLine(" LongestSubstring with {0} repeating characters {1}", 3, LongestSubstringWithAtleastKRepeatingCharacters("aaabb", 3));
        //  Console.WriteLine(" LongestSubstring with {0} repeating characters {1}", 2, LongestSubstringWithAtleastKRepeatingCharacters("ababbc", 2));

        // Input: "abcabcbb"
        // Output: 3 
        // Explanation: The answer is "abc", with the length of 3.
        //            Console.WriteLine(" LongestSubstring without repeating characters abcabcbb are {0} ", LongestSubstringWithoutRepeatingCharacters("abcabcbb"));
        // Input: "bbbbb"
        // Output: 1
        // Explanation: The answer is "b", with the length of 1.
        //          Console.WriteLine(" LongestSubstring without repeating characters bbbbb are {0} ", LongestSubstringWithoutRepeatingCharacters("bbbbb"));
        // Input: "pwwkew"
        // Output: 3
        // Explanation: The answer is "wke", with the length of 3. 
        // Note that the answer must be a substring, "pwke" is a subsequence  and not a substring.
        //        Console.WriteLine(" LongestSubstring without repeating characters pwwkew are {0} ", LongestSubstringWithoutRepeatingCharacters("pwwkew"));
        // Input: "dvdf"
        // Output: 3
        // Explanation: The answer is "vdf", with the length of 3. 
        // Console.WriteLine(" LongestSubstring without repeating characters dvdf are {0} ", LongestSubstringWithoutRepeatingCharacters("dvdf"));
        //Console.WriteLine(" Length Of Longest Substring Two Distinct eceba are {0} ", LengthOfLongestSubstringTwoDistinct("eceba"));
        //  Console.WriteLine(" Length Of Longest Substring Two Distinct ccaabbb are {0} ", LengthOfLongestSubstringTwoDistinct("ccaabbb"));


        //}
        public static int LongestSubstringWithAtleastKRepeatingCharacters(string s, int k)
        {
            if (s == null || s.Length == 0)
                return 0;

            int start = 0, maxLength = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            HashSet<int> set = new HashSet<int>();
            for (int end = 0; end < s.Length; end++)
            {
                if (map.ContainsKey(s[end]))
                    map[s[end]] = map.GetValueOrDefault(s[end], 0) + 1;
                else
                    map.Add(s[end], 1);

                if (!set.Contains(s[end]))
                {
                    set.Add(s[end]);
                }

                while (set.Count > 2 && start < s.Length)
                {
                    if (map.ContainsKey(s[start]))
                        map[s[start]] = map.GetValueOrDefault(s[start], 0) - 1;
                    else
                        map.Add(s[start], 1);

                    if (map[s[start]] < k)
                    {
                        map.Remove(s[start]);
                        set.Remove(s[start]);
                    }

                    start++;
                }
                maxLength = Math.Max(maxLength, end - start + 1);
            }
            return maxLength;
        }

        public static int LongestSubstringWithoutRepeatingCharacters(string s)
        {
            int start = 0, maxLen = 0, end = 0;
            HashSet<char> map = new HashSet<char>();
            //abcabcbb 
            for (end = 0; end < s.Length; end++)
            {
                //Add char to dictionary
                if (map.Contains(s[end]))
                {
                    while (map.Contains(s[end]) && start <= end)//shrink the window
                    {
                        map.Remove(s[start++]);
                    }
                }
                if (!map.Contains(s[end]))
                {
                    map.Add(s[end]);
                }
                maxLen = Math.Max(maxLen, end - start + 1);
            }
            return maxLen;
        }

        public static int LengthOfLongestSubstringTwoDistinct(string s)
        {
            int start = 0, maxLength = 0;
            HashSet<char> set = new HashSet<char>();
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int end = 0; end < s.Length; end++)
            {
                if (map.ContainsKey(s[end]))
                    map[s[end]] = map.GetValueOrDefault(s[end]) + 1;
                else
                    map.Add(s[end], 1);

                if (!set.Contains(s[end]))
                    set.Add(s[end]);

                while (set.Count > 2 && start < s.Length)
                {
                    map[s[start]] = map.GetValueOrDefault(s[start]) - 1;
                    if (map.GetValueOrDefault(s[start]) == 0)
                    {
                        map.Remove(s[start]);
                        set.Remove(s[start]);
                    }
                    start++;
                }
                maxLength = Math.Max(maxLength, end - start + 1);
            }
            return maxLength;
        }

        /*
          Search a substring of given length
          that occurs at least 2 times.
          Return start position if the substring exits and -1 otherwise.
          */
        public int Search(int L, int n, String S)
        {
            HashSet<int> seen = new HashSet<int>();
            String tmp;
            int h;
            for (int start = 0; start < n - L + 1; ++start)
            {
                tmp = S.Substring(start, start + L);
                h = tmp.GetHashCode();
                if (seen.Contains(h)) return start;
                seen.Add(h);
            }
            return -1;
        }

        public int LongestRepeatingSubstring(String S)
        {
            int n = S.Length;
            // binary search, L = repeating string length
            int left = 1, right = n;
            int L;
            while (left <= right)
            {
                L = left + (right - left) / 2;
                if (Search(L, n, S) != -1) left = L + 1;
                else right = L - 1;
            }
            return left - 1;
        }

        //      public string[] ReorderLogFiles(string[] logs) {
        //         Array.Sort(logs, (log1, log2) -> {
        //         String[] split1 = log1.split(" ", 2);
        //         String[] split2 = log2.split(" ", 2);
        //         boolean isDigit1 = char.IsDigit(split1[1][0]);
        //         boolean isDigit2 = char.IsDigit(split2[1][0]);
        //         if (!isDigit1 && !isDigit2) {
        //             int cmp = split1[1].compareTo(split2[1]);
        //             if (cmp != 0) return cmp;
        //             return split1[0].compareTo(split2[0]);
        //         }
        //         return isDigit1 ? (isDigit2 ? 0 : 1) : -1;
        //     });
        //     return logs;
        // }

    }
}
