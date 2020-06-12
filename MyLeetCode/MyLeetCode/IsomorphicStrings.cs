using System.Collections.Generic;

namespace myleetcode
{
    public class IsomorphicStringsClass
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length == 0 && t.Length == 0) return true;
            if (s.Length == 0 || t.Length == 0 || s.Length != t.Length) return false;
            // int[] m1 = new int[256];//Extended ASCII
            // int[] m2 = new int[256];//Extended ASCII
            // int n = s.Length;
            // int label = 1;
            // for (int i = 0; i < n; i++)
            // {
            //     int c1 = s[i];
            //     int c2 = t[i];
            //     if (m1[c1] != m2[c2])
            //     { return false; }
            //     if (m1[c1] == 0)
            //     {
            //         m1[c1] = 1;
            //         m2[c2] = 1;
            //         label++;
            //     }
            // }
            // return true;

            Dictionary<char, char> map = new Dictionary<char, char>();
            int size = s.Length;
            for (int i = 0; i < size; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    if (t[i] != map.GetValueOrDefault(s[i]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (map.ContainsValue(t[i]))
                    {
                        return false;
                    }
                    map.Add(s[i], t[i]);
                }
            }
            return true;
        }
    }

}