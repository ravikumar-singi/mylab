using System;
using MyLeetCode;

namespace myleetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseInteger rv = new ReverseInteger();
            // long a = rv.Reverse(1534236469);
            // int ab = rv.Java_Reverse(-134236469);
            //FibonacciNumber fibonacci = new FibonacciNumber();
            //int ab=fibonacci.Fib(8);
            // AddtoArrayFormofInteger atrr = new AddtoArrayFormofInteger();
            //int[] inr = new int[] { 1,2,3,4 };
            //IList<int> lst = atrr.AddToArrayForm(inr, 1);
            // PlusOne one = new PlusOne();
            // int[] inr = new int[] { 1, 1, 1 };
            // int[] lst = one.PlusOneMethod(inr);
            // Console.WriteLine(ConvertStringArrayToStringJoin(lst));

            //AddBinary one = new AddBinary();
            //Console.WriteLine(one.AddBinaryMethod("1010", "1011"));
            // ReconstructQueue reconstructQueue = new ReconstructQueue();
            // int[][] a = new int[][]{new int[]{7,0},new int[]{4,4},
            // new int[]{7,1},new int[]{5, 0 }, new int[]{ 6, 1 }, new int[]{ 5, 2 } };
            // reconstructQueue.ReconstructedQueue(a);

            //            CountPrimesSolution countPrimes = new CountPrimesSolution();
            //PowerOfTwo p2 = new PowerOfTwo();
            //Console.WriteLine(p2.isPowerOfTwo(9));
            // Console.WriteLine(countPrimes.CountPrimes(25));

            // BuddyString buddyString = new BuddyString();
            // Console.WriteLine(buddyString.IsBuddyStrings("ab", "bav"));

            // SearchInsertPosition sr = new SearchInsertPosition();
            // Console.WriteLine(sr.SearchInsert(new int[] { 1, 3, 5, 6 }, 7));

            // RemoveElementClass remove = new RemoveElementClass();
            // int[] nums = new int[] { 3,  2, 2, 3 };
            // Console.WriteLine(remove.RemoveElement(nums, 3));

            // SortColorClass sortColor = new SortColorClass();
            // int[] nums = new int[] { 2, 0, 1 };
            // sortColor.SortColors(nums);
            // Console.WriteLine(ConvertStringArrayToStringJoin(nums));

            //  ToLowerClass toLowerClass = new ToLowerClass();
            //  Console.WriteLine(toLowerClass.ToLowerCase("HeLLeLuiAlo"));

            ReverseVovels reverse = new ReverseVovels();
            Console.WriteLine(reverse.ReverseVowels("LeetCode"));


        }

        static string ConvertStringArrayToStringJoin(int[] array)
        {
            string result = string.Join(",", array);
            return result;
        }
    }
}
