using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles("TestFolder");

            long sizeBytes = 0;
            const int BytesInKB = 1024;
            const int KBinMB = 1024;

            foreach (var path in filePaths)
            {
                FileInfo fileInfo = new FileInfo(path);
                sizeBytes += fileInfo.Length;
            }
            double sizeMegabytes = sizeBytes / (double) (BytesInKB * KBinMB);
            File.WriteAllText("output.txt", sizeMegabytes.ToString());

        }
    }
}
