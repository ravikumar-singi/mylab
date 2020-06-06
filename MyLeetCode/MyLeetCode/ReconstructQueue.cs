using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyLeetCode
{
    public class MyComparer : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a[0] != b[0]) return b[0] - a[0];
            else return a[1] - b[1];
        }
    }
    public class ReconstructQueue
    {
        public int[][] ReconstructedQueue(int[][] people)
        {
            Array.Sort(people, new MyComparer());
            List<int[]> list = new List<int[]>();
            foreach (int[] ppl in people)
            {
                list.Insert(ppl[1], ppl);
            }
            return list.ToArray<int[]>();
        }
    }
}