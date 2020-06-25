using System.Collections.Generic;
using System.Text;

namespace myleetcode
{
    public class PermutationSequence
    {
        public string GetPermutation(int n, int k)
        {
            int[] fact = new int[n + 1];
            System.Array.Fill(fact, 1);
            List<int> nums = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                fact[i] = fact[i - 1] * i;
                nums.Add(i);
            }
            StringBuilder ans = new StringBuilder();
            for (int i = 0, l = k - 1; i < n; i++)
            {
                int index = l / fact[n - 1 - i];
                ans.Append(nums.Remove(index));
                l = l - index * fact[n - 1 - i];
            }
            return ans.ToString();
        }
    }
}