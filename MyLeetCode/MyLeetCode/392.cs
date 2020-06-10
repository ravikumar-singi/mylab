namespace myleetcode
{
    class SequenceClass
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Equals("")) return true;
            int i = 0;
            for (int j = 0; j < t.Length; j++)
            {
                if (t[j] == s[i])
                {
                    i++;
                }

                if (i >= s.Length) return true;
            }
            return false;
        }
    }
}