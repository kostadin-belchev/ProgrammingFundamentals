using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class AnonymousThreat
{
    static void Main()
    {
        var arrayOfData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "3:1")
                break;

            string[] inputLineTokens = inputLine.Split(' ').ToArray();

            string command = inputLineTokens[0];
            
            switch (command)
            {
                case "merge":
                    int startIndex = int.Parse(inputLineTokens[1]);
                    int endIndex = int.Parse(inputLineTokens[2]);
                    Merge(arrayOfData, startIndex, endIndex);
                    break;
                case "devide":
                    int index = int.Parse(inputLineTokens[1]); //Could it be bigInt??
                    int partitions = int.Parse(inputLineTokens[2]);
                    Devide(arrayOfData, index, partitions);
                    break;
                default:
                    //Console.WriteLine("Kosta test: Invalid command");
                    break;
            }
        }
        Console.WriteLine(string.Join(" ", arrayOfData));
    }

    private static void Devide(List<string> arrayOfData, int index, int partitions)
    {
        char[] stringToDevide = arrayOfData[index].ToCharArray();

        var lenghOfChunks = stringToDevide.Length / partitions;

        List<string> listOfSubstrings = new List<string>();

        for (int i = 0; i < partitions; i++)
        {
            var chunkToAdd = stringToDevide.Skip(partitions*i).Take(lenghOfChunks).ToArray().ToString();
            listOfSubstrings.Add(chunkToAdd);
        }

        arrayOfData.RemoveRange(index, 1);

        arrayOfData.AddRange(listOfSubstrings);
    }

    private static void Merge(List<string> arrayOfData, int startIndex, int endIndex)
    {
        if (startIndex < 0)
            startIndex = 0;
        else if (startIndex > arrayOfData.Count - 1)
        {
            startIndex = 0;
            endIndex = 0;
        }

        if (endIndex > arrayOfData.Count - 1)
            endIndex = arrayOfData.Count - 1;
        else if (endIndex < 0)
        {
            startIndex = 0;
            endIndex = 0;
        }

        if (!(startIndex == 0 && endIndex == 0))
        {
            List<string> listToMerge = new List<string>();

            for (int i = startIndex; i <= endIndex; i++)
                listToMerge.Add(arrayOfData[i]);

            arrayOfData.RemoveRange(startIndex, endIndex - startIndex + 1);

            arrayOfData.Insert(startIndex, string.Join(string.Empty, listToMerge));
        }
    }
}

