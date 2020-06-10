using System;
using System.Collections.Generic;
using System.Linq;
public class RemoveElementClass
{
    public int RemoveElement(int[] nums, int val)
    {
        // List<int> arrayList = nums.ToList<int>();
        // int i = arrayList.RemoveAll(i => i == val);
        // for (int i1 = 0; i1 < arrayList.Count; i1++)
        // {
        //     Console.WriteLine(arrayList[i1].ToString());
        // }
        // return nums.Length - i;
        int i = 0;
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] != val)
            {
                nums[i] = nums[j];
                i++;
            }
        }
        foreach (var item in nums)
        {
            Console.WriteLine(item.ToString());
        }
        return i;

    }
}