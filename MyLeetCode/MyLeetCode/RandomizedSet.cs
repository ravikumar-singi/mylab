using System.Collections.Generic;
namespace myleetcode
{
    public class RandomizedSet
    {
        List<int> nums;
        Dictionary<int, int> locs;
        System.Random rand;
        /** Initialize your data structure here. */
        public RandomizedSet()
        {
            nums = new List<int>();
            locs = new Dictionary<int, int>();
            rand = new System.Random();
        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            bool contain = locs.ContainsKey(val);
            if (contain) return false;
            locs.Add(val, nums.Count);
            nums.Add(val);
            return true;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            bool contain = locs.ContainsKey(val);
            if (!contain) return false;
            int loc = locs[val];
            if (loc < nums.Count - 1)
            { // not the last one than swap the last one with this val
                int lastone = nums[nums.Count - 1];
                nums.Insert(loc, lastone);
                locs.Add(loc, lastone);
            }
            locs.Remove(val);
            nums.Remove(nums.Count - 1);
            return true;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            return nums[rand.Next(nums.Count)];
        }
    }
}