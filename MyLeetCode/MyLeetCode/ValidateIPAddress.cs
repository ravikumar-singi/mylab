namespace myleetcode
{
    public class ValidateIP
    {
        public string ValidIPAddress(string IP)
        {
            if (IP.Contains("."))
            {
                string[] stringArray = IP.Split(".");

                if (stringArray.Length == 0 || stringArray.Length != 4) return "Neither";
                else
                {
                    //IsValidIpv4(IP);
                    foreach (var item in stringArray)
                    {
                        if (item.Length == 0 || item.Length > 3) return "Neither";
                        if (item[0].Equals('0') && item.Length != 1)
                        {
                            return "Neither";
                        }
                        foreach (var ch in item)
                        {
                            if (!char.IsDigit(ch)) return "Neither";

                        }
                        if (int.Parse(item) > 255) return "Neither";
                    }
                    return "IPv4";
                }
            }
            else if (IP.Contains(":"))
            {
                string[] stringArray = IP.Split(":");
                if (stringArray.Length == 0 || stringArray.Length != 8) return "Neither";
                else
                {
                    //IsValidIpv4(IP);
                    foreach (var item in stringArray)
                    {
                        if (item.Length == 0 || item.Length > 4) return "Neither";
                        //if (item[0].Equals('0') && item.Length != 1) return "Neither";
                        foreach (var ch in item)
                        {
                            if (!System.Uri.IsHexDigit(ch)) return "Neither";

                        }
                    }
                }
                return "IPv6";
            }
            else
                return "Neither";
            //Return "IPv4" if IP is IPv4
            //Return "IPv6" if IP is IPv6
            //Neither
        }
    }
}