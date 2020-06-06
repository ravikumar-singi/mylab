namespace MyLeetCode
{
    public class AddTwoStrings
    {
        public static string AddStrings(string num1, string num2)
        {
            int carry = 0;
            int m = num1.Length - 1;
            int n = num2.Length - 1;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while (m >= 0 || n >= 0 || carry != 0)
            {
                if (m >= 0)
                {
                    carry += (num1[m] - '0');
                    m--;
                }
                if (n >= 0)
                {
                    carry += (num2[n] - '0');
                    n--;
                }
                sb.Insert(0, carry % 10);
                carry = carry / 10;
            }
            return sb.ToString();
        }
    }
}