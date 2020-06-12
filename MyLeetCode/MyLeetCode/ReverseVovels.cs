namespace myleetcode
{
    public class ReverseVovels
    {
        //Write a function that takes a string as input and reverse only the vowels of a string.
        public string ReverseVowels(string s)
        {
            int start = 0;//first pointer
            int end = s.Length - 1;//Second pointer
            var strChar = s.ToCharArray();
            while (start < end)
            {
                if (!IsVowel(s[start]))
                {
                    start++;
                    continue;
                }

                if (!IsVowel(s[end]))
                {
                    end--;
                    continue;
                }

                char temp = strChar[end];
                strChar[end] = s[start];
                strChar[start] = temp;

                start++;
                end--;
            }

            return new string(strChar);
        }
        private bool IsVowel(char v)
        {
            bool isVowel = false;
            switch (v)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    isVowel = true;
                    break;
            }

            return isVowel;
        }
    }
}