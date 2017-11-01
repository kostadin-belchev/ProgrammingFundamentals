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
            List<string> allFiles = new List<string>();

            for (long i = 0; i < N; i++)
            {
                allFiles.Add(Console.ReadLine());
            }

            string[] searchItems = Console.ReadLine().Split().ToArray();
            string extension = searchItems[0];
            string root = searchItems[2];

            //program
            Dictionary<string, long> fileSize = new Dictionary<string, long>();

            foreach (var file in allFiles)
            {
                var filePlusSize = file.Split(';');
                var size = long.Parse(filePlusSize[1]);
                var filePath = filePlusSize[0];

                if (filePath.EndsWith("." + extension) && filePath.StartsWith(root + @"\"))
                {
                    var pathTokens = filePath.Split('\\');
                    var fileName = pathTokens.Last();
                    //fileSize[fileName] = size;
                    if (!fileSize.ContainsKey(fileName))
                    {
                        fileSize.Add(fileName, size);
                    }
                    else if (fileSize.ContainsKey(fileName) && fileSize[fileName] < size)
                    {
                        fileSize[fileName] = size;
                    }
                        

                }
            }
            //Ordering as per requirements
            fileSize = fileSize.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary( x => x.Key, y => y.Value);

            //output
            if (fileSize.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var keyValuePair in fileSize)
                {
                    Console.WriteLine(keyValuePair.Key + " - " + keyValuePair.Value + " KB");
                }
            }
            
           
        }
    }
}
