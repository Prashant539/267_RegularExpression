using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class LowerCaseSequence
    {
        public static void CheckLowerCase()
        {
            Console.WriteLine("Enter the name: ");
            string word = Console.ReadLine();
            Regex regex = new Regex("^[a-z]+_[a-z]+$");
            if(regex.IsMatch(word))
            {
                Console.WriteLine("String is valid");
            }
            else
            {
                Console.WriteLine("String is not valid");
            }
        }
    }
}
