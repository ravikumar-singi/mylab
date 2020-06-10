namespace myleetcode
{
    class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            // int minPosition = 0, maxPosition = 0;
            // int minValue = 0, maxValue = 0;
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     if (target == nums[i]) return i;
            //     else if (target < nums[i] && target > minValue) { minPosition = i; minValue = nums[i]; }
            //     else if (target > nums[i] && target > maxValue) { maxPosition = i; maxValue = nums[i]; }
            // }
            // if (maxPosition > 0) return maxPosition;
            // if (minPosition > 0) return minPosition;

            //     int l = 0, r = nums.Length - 1, mid = 0;
            //     if (target <= nums[0]) return 0;
            //     else if (target >= nums[nums.Length - 1]) return nums.Length;
            //     else
            //     {
            //         while (l + 1 < r)
            //         {
            //             mid = l + (r - l) / 2;
            //             if (nums[mid] == target) return mid;
            //             else if (target < nums[mid])
            //                 return r = mid;
            //             else
            //                 l = mid;
            //         }

            //         if (nums[r] < target)
            //             return r + 1;
            //         else if (nums[l] >= target)
            //             return l;
            //         else
            //             return r;
            //     }

            int i = 0;
            int j = nums.Length - 1;

            while (i <= j)
            {
                int mid = (i + j) / 2;
                if (target > nums[mid])
                {
                    i = mid + 1;
                }
                else if (target < nums[mid])
                {
                    j = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return i;
        }
    }
}