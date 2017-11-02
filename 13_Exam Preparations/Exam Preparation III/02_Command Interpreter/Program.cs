using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //input
        List<string> items = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        
        var exceptionCounter = 0;

        while (true)
        {
            var commandLine = Console.ReadLine();

            if (commandLine == "end")
                break;

            List<string> commandTokens = commandLine.Split(' ').ToList();
            var commandName = commandTokens[0];

            switch (commandName)
            {
                case "reverse":
                    try
                    {
                        var start = int.Parse(commandTokens[2]);
                        var count = int.Parse(commandTokens[4]);
                        items.Reverse(start, count);
                    }
                    catch (Exception)
                    {
                        exceptionCounter++;
                    }
                    break;
                case "sort":
                    try
                    {
                        var start = int.Parse(commandTokens[2]);
                        var count = int.Parse(commandTokens[4]);
                        items.Sort(start, count, null);
                    }
                    catch (Exception)
                    {
                        exceptionCounter++;
                    }
                    break;
                case "rollLeft":
                    try
                    {
                        var count = int.Parse(commandTokens[1]);
                        RollLeft(items, count);
                    }
                    catch (Exception)
                    {
                        exceptionCounter++;
                    }
                    break;
                case "rollRight":
                    try
                    {
                        var count = int.Parse(commandTokens[1]);
                        items = RollRight(items, count);
                    }
                    catch (Exception)
                    {
                        exceptionCounter++;
                    }
                    break;
                default:
                    break;
            }
        }

        //output
        if (exceptionCounter != 0)
        {
            for (int i = 0; i < exceptionCounter; i++)
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }
        Console.WriteLine($"[{string.Join(", ", items)}]");
    }

    private static void RollLeft(List<string> items, int count)
    {
        int positions = count % items.Count;
        for (int i = 0; i < positions; i++)
        {
            var lastElement = items[0];
            for (int j = 0; j < items.Count - 1; j++)
            {
                items[j] = items[j + 1];
            }
            items[items.Count - 1] = lastElement;
        }
    }

    private static List<string> RollRight(List<string> A, int k)
    {
        //Rotate an array to the right by a given number of steps.
        // eg k= 1 A = [3, 8, 9, 7, 6] the result is [6, 3, 8, 9, 7]
        // eg k= 3 A = [3, 8, 9, 7, 6] the result is [9, 7, 6, 3, 8]
        int K = k % A.Count;

        if (A.Count == 0 || A.Count == 1)
            return A;

        string lastElement;
        List<string> newArray = new List<string>();

        List<string> listOfNumbers = new List<string>();

        for (int i = 1; i < K + 1; i++)
        {

            lastElement = A[A.Count - 1];
            newArray = A.Take(A.Count - 1).ToList();
            listOfNumbers = newArray.ToList<string>();
            listOfNumbers.Insert(0, lastElement);

            A = listOfNumbers.ToList();
            newArray = A;

        }
        return newArray;
        
    }

    
}

