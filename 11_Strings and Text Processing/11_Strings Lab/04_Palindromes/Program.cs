using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> words = input.Split(new char[] { ' ', '!', '?', '.', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> palindromes = new List<string>();

            foreach (var word in words)
            {
                if (IsPalindrome(word))
                    palindromes.Add(word);
            }
            //palindromes = palindromes.Distinct().ToList();
            palindromes = palindromes.OrderBy(x => x).Distinct().ToList();

            Console.WriteLine(string.Join(", ", palindromes));
        }

        public static bool IsPalindrome(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }
    }
}
