using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



class AnonymousVox
{
    static void Main()
    {
        string encodedText = Console.ReadLine();
        string placeholders = Console.ReadLine();

        string pattern = @"([A-Z0-9a-z]+).*?(\1)";

        var matches = Regex.Matches(encodedText, pattern);

        //string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
        string replacement = placeholders;
        string replaced = Regex.Replace(encodedText, pattern, replacement);

        Console.WriteLine(replaced);
    }
}

