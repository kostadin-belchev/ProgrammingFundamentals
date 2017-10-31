using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            long N = long.Parse(Console.ReadLine());
            Dictionary<string, decimal> pathAndSize = new Dictionary<string, decimal>();
            Dictionary<string, decimal> nameOfExtensionAndSize = new Dictionary<string, decimal>();

            for (int i = 0; i < N; i++)
            {
                string[] currPathAndSize = Console.ReadLine().Split(';').ToArray();
                pathAndSize.Add(currPathAndSize[0], decimal.Parse(currPathAndSize[1]));
            }

            List<string> paths = new List<string>();
            foreach (var path in pathAndSize)
            {
                paths = path.Key.Split('\\').ToList();
            }

            string[] searchItems = Console.ReadLine().Split().ToArray();
            string extension = searchItems[0];
            string root = searchItems[2];

            //program
            foreach (var keyValuePair in nameOfExtensionAndSize)
            {
                
            }

            //output
        }
    }
}
