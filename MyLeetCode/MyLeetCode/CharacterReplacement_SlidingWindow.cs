using System;
using System.Collections.Generic;

namespace MyLeetCode
{
    /* 
    Given a string with lowercase letters only; if you are allowed to replace no more than k letters with any
    letter, find the Length of the longest substring having the same letters after replacement.
    */
    public class CharacterReplacement_SlidingWindow
    {
        static void Main()
        {
            Console.WriteLine("Longest repeating substring s={0} with K={1} operations is{2}", "ABAB", 2, CharacterReplacement("ABAB", 2));
            Console.WriteLine("Longest repeating substring s={0} with K={1} operations is{2}", "AABABBA", 1, CharacterReplacement("AABABBA", 1));
            Console.WriteLine("Longest repeating substring s={0} with K={1} operations is{2}", "AABA", 0, CharacterReplacement("AABA", 0));
            Console.WriteLine("Longest repeating substring s={0} with K={1} operations is{2}", "ABAA", 0, CharacterReplacement("ABAA", 0));
            Console.WriteLine("Longest repeating substring s={0} with K={1} operations is{2}", "ABCDE", 1, CharacterReplacement("ABCDE", 1));
        }
        public static int CharacterReplacement(string s, int k)
        {
            int start = 0, maxLen = 0, maxRepeatingCharCount = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            HashSet<char> set = new HashSet<char>();
            for (int end = 0; end < s.Length; end++)
            {
                if (map.ContainsKey(s[end]))
                {
                    map[s[end]] = map.GetValueOrDefault(s[end]) + 1;
                    maxRepeatingCharCount = Math.Max(maxRepeatingCharCount, map.GetValueOrDefault(s[end]));
                }
                else
                {
                    map.Add(s[end], 1);
                    set.Add(s[end]);
                }
                if (k > 0)
                {
                    while ((end - start - maxRepeatingCharCount + 1) > k)
                    {
                        map[s[start]] = map.GetValueOrDefault(s[start]) - 1;
                        if (map[s[start]] <= 0)
                        {
                            map.Remove(s[start]);
                            set.Remove(s[start]);
                        }
                        start++;
                    }
                }
                else
                {
                    while (set.Count > 1)
                    {
                        map[s[start]] = map.GetValueOrDefault(s[start]) - 1;
                        if (map[s[start]] <= 0)
                        {
                            map.Remove(s[start]);
                            set.Remove(s[start]);
                        }
                        start++;
                    }
                }
                maxLen = Math.Max(maxLen, end - start + 1);
            }
            return maxLen;
        }
    }
}