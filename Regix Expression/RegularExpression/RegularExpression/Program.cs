using System;
namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression");
            Console.WriteLine("Input options to perform program");
            Console.WriteLine("1:String Match\n2:Lower case");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    StringMatch.CheckStringMatch();
                    break;
                case 2:
                    LowerCaseSequence.CheckLowerCase();
                    break;


            }
        }
    }
}
