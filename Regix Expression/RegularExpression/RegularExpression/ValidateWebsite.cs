using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace RegularExpression
{
    public class ValidateWebsite
    {
        public static void CheckValidateWebsite()
        {
            Regex regex = new Regex((@"^(http|http(s)?://)?([\w-]+\.)+[\w-]+[.com|.in|.org]+(\[\?%&=]*)?"));
            Console.WriteLine("Enter the url");
            string url = Console.ReadLine();
            if(regex.IsMatch(url))
            {
                Console.WriteLine("It is valid");
            }
            else
            {
                Console.WriteLine("It is not valid");
            }
        }
    }
}
