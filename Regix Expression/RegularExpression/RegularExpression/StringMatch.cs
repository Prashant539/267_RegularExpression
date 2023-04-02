using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class StringMatch
    {
        public static void CheckStringMatch()
        {
            string input = "abbb";
            string pattern = "^[a]{1}[b]{2,3}$";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(input))
            {
                Console.WriteLine("String is matches with pattern ");
            }
            else
            {
                Console.WriteLine("String is not matches with pattern"); 
            }
        }
    }
}
