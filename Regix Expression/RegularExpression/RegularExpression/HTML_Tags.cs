using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class HTML_Tags
    {
        public static void CheckHTMLtags()
        {
            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>”";
            string pattern = @"<[^>]+>";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
