using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Static__Extentions.Helpers
{
    public static class Extention
    {                           //Digit
        public static bool CheckString(this string str,string pattern)
        {
            //var result = Regex.IsMatch(str, @"\d");
            //return result;
            //return Regex.IsMatch(str, @"\d");
            return Regex.IsMatch(str, pattern);

            
        }
        public static int SumNumbers(this int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
