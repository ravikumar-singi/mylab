// A Naive recursive C# program to find if given string is K-Palindrome or not 
using System;
namespace Leetcode
{
    public class GFG
    {
        // // find if given string is K-Palindrome or not 
        // static int isKPalRec(string str1, string str2, int m, int n)
        // {
        //     // If first string is empty, the only option is to remove all characters of second string 
        //     if (m == 0)
        //     {
        //         return n;
        //     }

        //     // If second string is empty, the only option is to remove all characters of first string 
        //     if (n == 0)
        //     {
        //         return m;
        //     }

        //     // If last characters of two strings are same, ignore last characters and get 
        //     // count for remaining strings. 
        //     if (str1[m - 1] == str2[n - 1])
        //     {
        //         return isKPalRec(str1, str2, m - 1, n - 1);
        //     }

        //     // If last characters are not same, 
        //     // 1. Remove last char from str1 and 
        //     // recur for m-1 and n 
        //     // 2. Remove last char from str2 and 
        //     // recur for m and n-1 
        //     // Take minimum of above two operations 
        //     return 1 + Math.Min(isKPalRec(str1, str2, m - 1, n), // Remove from str1 
        //             isKPalRec(str1, str2, m, n - 1)); // Remove from str2 
        // }

        // // Returns true if str is k palindrome. 
        // static bool isKPal(String str, int k)
        // {
        //     String revStr = str;
        //     revStr = reverse(revStr);
        //     int len = str.Length;

        //     return (isKPalRec(str, revStr, len, len) <= k * 2);
        // }

        // static String reverse(String input)
        // {
        //     char[] temparray = input.ToCharArray();
        //     int left, right = 0;
        //     right = temparray.Length - 1;

        //     for (left = 0; left < right; left++, right--)
        //     {
        //         // Swap values of left and right 
        //         char temp = temparray[left];
        //         temparray[left] = temparray[right];
        //         temparray[right] = temp;
        //     }
        //     return String.Join("", temparray);
        // }

        public static bool IsValidPalindrome(String str, int k)
        {
            int n = str.Length;
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reverseStr = new string(charArray);
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder(reverseStr);

            int lps = lcs(str, stringBuilder.ToString(), n, n);
            return (n - lps <= k);
        }

        /*
        longest palindromic subsequence:
        LCS of the given string & its reverse will be the longest palindromic sequence.
         */
        static private int lcs(String X, String Y, int m, int n)
        {
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }
                    else if (X[i - 1] == Y[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }
            return dp[m, n];
        }
        // Driver code 
        public static void Main(String[] args)
        {
            String str = "cccabbcccbdcaaabbcdbddccaddccbabbabdbaaabbbbdcabacccbbdbbbdbdcdd";
            int k = 1;
            if (IsValidPalindrome(str, k))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
