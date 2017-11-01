using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> items = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var command = Console.ReadLine();
        var exceptionCounter = 0;

        while (!(command == "end"))
        {
            List<string> commands = command.Split(' ').ToList();
            
            if (commands[0] == "reverse")
            {
                try
                {
                    var start = int.Parse(commands[2]);
                    var count = int.Parse(commands[4]);
                    items.Reverse(start, count);
                }
                catch (Exception)
                {
                    exceptionCounter++;
                }
            }
            else if (commands[0] == "sort")
            {
                try
                {
                    var start = int.Parse(commands[2]);
                    var count = int.Parse(commands[4]);
                    items.Sort(start, count, null);
                }
                catch (Exception)
                {
                    exceptionCounter++;
                }
            }
            else if (commands[0] == "rollLeft")
            {
                try
                {
                    var count = int.Parse(commands[1]);

                }
                catch (Exception)
                {
                    exceptionCounter++;
                }
                
            }

            command = Console.ReadLine();
        }

        if (exceptionCounter != 0)
        {
            for (int i = 0; i < exceptionCounter; i++)
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }
        Console.WriteLine($"[{string.Join(", ", items)}]");
    }
}

