namespace myleetcode
{
    public class ToLowerClass
    {
        public string ToLowerCase(string str)
        {
            byte[] asciiBytes = System.Text.Encoding.ASCII.GetBytes(str);

            for (int i = 0; i < asciiBytes.Length; i++)
            {
                if (asciiBytes[i] >= (int)65 && asciiBytes[i] <= (int)90)
                {
                    asciiBytes[i] = (byte)(asciiBytes[i] + (System.Byte)32);
                }
            }

            return System.Text.Encoding.ASCII.GetString(asciiBytes, 0, asciiBytes.Length);
        }
    }
}