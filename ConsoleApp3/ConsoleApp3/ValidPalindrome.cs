using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    public static class ValidPalindrome
    {
        public static bool isPlindrome(string s)
        {
            s = Regex.Replace(s, "[^a-zA-Z0-9]", "");
            s = s.ToLower();
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            string rs = new string(chars);
            if (rs == s)
            {
                return true;
            }
            return false;
        }
    }
}
