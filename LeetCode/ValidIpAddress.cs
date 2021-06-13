public class IPAddress
{
    public string ValidIPAddress(string IP)
    {
        var ipAddr = IP.Split(new char[] { '.', ':' }, System.StringSplitOptions.None);
        bool flag = true;
        if (ipAddr.Length == 4)
        {
            //IPv4
            foreach (string str in ipAddr)
            {
                if (str.StartsWith("0") && str.Length > 1)
                {
                    flag = false;
                    break;
                }
                int number = 0;
                if (!Int32.TryParse(str, out number) || number < 0 || number > 255)
                {
                    flag = false;
                    break;
                }

            }
            if (flag == true)
                return "IPv4";

        }
        else if (ipAddr.Length == 8)
        {
            // IPv6

            foreach (var str in ipAddr)
            {
                if (str.Length > 4)
                {
                    flag = false;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(str, @"\A\b[0-9a-fA-F]+\b\Z"))
                    flag = false;
            }
            if (flag == true)
                return "IPv6";
        }
        else flag = false;
        if (flag == false)
            return "Neither";
        return "Neither";
    }
}