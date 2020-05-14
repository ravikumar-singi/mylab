public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] answer = new int[2];

        Dictionary<int, int> myDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (myDict.ContainsKey(target - nums[i]))
            {
                answer[1] = i;
                answer[0] = myDict[target - nums[i]];
                break;
            }

            else if (!myDict.ContainsKey(nums[i])) myDict.Add(nums[i], i);
        }

        return answer;
    }

    public static void main(string[] args)
    {
        int[] arr = TwoSum()
    }
}