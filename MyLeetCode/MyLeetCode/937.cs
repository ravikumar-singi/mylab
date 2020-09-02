using System.Collections;
namespace  myleetcode{
public class Solution {
        public string[] ReorderLogFiles(string[] logs) {
        
                    Comparer comparer= new Comparer(System.Globalization.CultureInfo.CurrentCulture){
                        public override int Compare(string log1, string log2) {
                            // split each log into two parts: <identifier, content>
                            string[] split1 = log1.Split(" ", 2);
                            string[] split2 = log2.Split(" ", 2);

                            bool isDigit1 = char.IsDigit(split1[1][0]);
                            bool isDigit2 = char.IsDigit(split2[1][0]);

                            // case 1). both logs are letter-logs
                            if (!isDigit1 && !isDigit2) {
                                // first compare the content
                                int cmp = split1[1].CompareTo(split2[1]);
                                if (cmp != 0)
                                    return cmp;
                                // logs of same content, compare the identifiers
                                return split1[0].CompareTo(split2[0]);
                            }

                            // case 2). one of logs is digit-log
                            if (!isDigit1 && isDigit2)
                                // the letter-log comes before digit-logs
                                return -1;
                            else if (isDigit1 && !isDigit2)
                                return 1;
                            else
                                // case 3). both logs are digit-log
                                return 0;
                        }
                       }
                    };

        Array.Sort()
        return logs;
    }
}
