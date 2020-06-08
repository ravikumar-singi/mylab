public class StrongPasswordChecker
{
    public int StrongPasswordCheckerMethod(string s)
    {
        //bool atLeastOneLower, atLeastOneUpper, atLeastOneDigit;

        // // It has at least 6 characters and at most 20 characters.
        // if (s.Length < 6 || s.Length > 20) { return 1; }
        // // It must contain at least one lowercase letter, at least one uppercase letter, and at least one digit.
        // for (int j = 0; j < s.Length; j++)
        // {
        //     if (System.Char.IsLower(s[j]) == true) atLeastOneLower = true;
        //     if (System.Char.IsUpper(s[j]) == true) atLeastOneLower = true;
        // }
        // // It must NOT contain three repeating characters in a row ("...aaa..." is weak, but "...aa...a..." is strong, assuming other conditions are met).
        //System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("/^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$/");

        return 0;//if the password is already strong
    }
}