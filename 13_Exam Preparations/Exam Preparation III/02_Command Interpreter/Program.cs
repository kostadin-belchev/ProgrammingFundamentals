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
                        RollRight(items, count); //This has to be changed
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

    private static void RollRight(List<string> items, int count)
    {
        //This has to be changed it rolls to the Left
        int positions = count % items.Count;
        for (int i = 0; i < positions; i++)
        {
            for (int j = 0; j < items.Count; j++)
            {
                items[(j + 1) % items.Count] = items[j];
            }
        }
    }

    
}

