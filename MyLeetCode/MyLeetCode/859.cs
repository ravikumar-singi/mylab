using System;
using System.Linq;
namespace myleetcode
{
    public class BuddyString
    {
        public bool IsBuddyStrings(string A, string B)
        {
            //1. remove common characters between both strings
            var query = String.Concat(A, B);
            System.Collections.Generic.IEnumerable<Char> charArray = query.Distinct();
            Console.WriteLine(charArray.ToString());
            //2. reverse the string b
            //3.If string A== string reverse B then true
            //4.else false
            //char[] charArray = s.ToCharArray();
            //Array.Reverse( charArray );
            //return new string( charArray );
            return true;
        }
    }
}