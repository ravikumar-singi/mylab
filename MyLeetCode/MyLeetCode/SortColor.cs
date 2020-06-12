namespace myleetcode
{
    public class SortColorClass
    {
        public void SortColors(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1) return;

            int start = 0;
            int end = nums.Length - 1;
            int index = 0;

            while (index <= end && start < end)
            {
                if (nums[index] == 0)
                {
                    nums[index] = nums[start];
                    nums[start] = 0;
                    start++;
                    index++;
                }
                else if (nums[index] == 2)
                {
                    nums[index] = nums[end];
                    nums[end] = 2;
                    end--;

                }
                else
                {
                    index++;
                }
            }


        }
    }
}
