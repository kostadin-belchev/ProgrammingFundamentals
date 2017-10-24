using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            List<int> results = new List<int>();

            foreach (int item in nums)
            {
                if (item >= 0)
                {
                    results.Add(item);
                }
            }
            results.Reverse();
            if (results.Count != 0)
            {
                for (int i = 0; i < results.Count; i++)
                {
                    Console.Write(results[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("empty");
            }
            
        }
    }
}
