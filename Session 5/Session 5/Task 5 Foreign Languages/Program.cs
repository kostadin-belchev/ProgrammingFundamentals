using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            string language;

            switch (countryName)
            {
                case "USA":
                case "England":
                    language = "English";
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    language = "Spanish";
                    break;
                default:
                    language = "unknown";
                    break;
            }
            Console.WriteLine(language);
        }
    }
}
