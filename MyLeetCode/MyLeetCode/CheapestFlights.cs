using System;
using System.Collections.Generic;

namespace myleetcode
{
    public class CheapestFlights
    {
        // public static void Main()
        // {
        //     Console.WriteLine(FindCheapestPrice(3, new int[][] { new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 0, 2, 500 } }, 0, 2, 1));
        //     Console.WriteLine(FindCheapestPrice(3, new int[][] { new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 0, 2, 500 } }, 0, 2, 0));
        // }

        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            // Map each src to list of destinations along with prices (list of tuple would work but we are using Dictionary here
            Dictionary<int, Dictionary<int, int>> prices = new Dictionary<int, Dictionary<int, int>>();

            foreach (int[] f in flights)
            {
                if (!prices.ContainsKey(f[0]))
                {
                    prices[f[0]] = new Dictionary<int, int>();
                }

                prices[f[0]].Add(f[1], f[2]);
            }

            // This acts as priority queue for lowest prices available to a tuple of <destination, step>
            // Note that a particular destination could have multiple entries here. However the lowest price ones
            // always appear first
            //SortedList<int, Tuple<int, int>> lowest = new SortedList<int, Tuple<int, int>>();
            SortedSet<Tuple<int, int, int>> lowest = new SortedSet<Tuple<int, int, int>>(new TupleComparer());

            // Add the src with 0 price and k + 1 step to destination
            //lowest.Add(0, new Tuple<int, int>(src, k + 1));
            lowest.Add(new Tuple<int, int, int>(0, src, k + 1));

            while (lowest.Count > 0)
            {
                //int cur_price = lowest.Keys[0];
                //int cur_dst = lowest[cur_price].Item1;
                //int cur_step = lowest[cur_price].Item2;

                /*
                Console.WriteLine("Current queue: ");
                foreach (Tuple<int, int, int> t in lowest) {
                    Console.WriteLine("{0}, {1}, {2}", t.Item1, t.Item2, t.Item3);
                }*/

                Tuple<int, int, int> top = lowest.Min;
                //Console.WriteLine("Current top: ");
                //Console.WriteLine("{0}, {1}, {2}", top.Item1, top.Item2, top.Item3);

                lowest.Remove(top);

                int cur_price = top.Item1;
                int cur_dst = top.Item2;
                int cur_stop = top.Item3;

                // We find the destination
                // cur_stop would never be smaller than 0 so no need to check
                if (cur_dst == dst)
                {
                    return cur_price;
                }

                if (cur_stop > 0 && prices.ContainsKey(cur_dst))
                {
                    Dictionary<int, int> next_dst = prices[cur_dst];

                    foreach (KeyValuePair<int, int> p in next_dst)
                    {
                        lowest.Add(new Tuple<int, int, int>(cur_price + p.Value, p.Key, cur_stop - 1));
                    }
                }
            }

            return -1;
        }

        public class TupleComparer : IComparer<Tuple<int, int, int>>
        {
            public int Compare(Tuple<int, int, int> x, Tuple<int, int, int> y)
            {
                return x.Item1.CompareTo(y.Item1);
            }
        }
    }
}