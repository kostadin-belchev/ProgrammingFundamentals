using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            

            while (true)
            {
                List<string> commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (commands[0] == "Delete")
                {
                    int numberToDelete = int.Parse(commands[1]);

                    while (nums.Contains(numberToDelete))
                    {
                        nums.Remove(numberToDelete);
                    }
                }
                if (commands[0] == "Insert")
                {
                    int elementToInsert = int.Parse(commands[1]);
                    int insertPosition = int.Parse(commands[2]);
                    nums.Insert(insertPosition, elementToInsert);
                }

                if (commands[0] == "Odd")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 != 0)
                        {
                            Console.Write(nums[i] + " ");
                        }
                    }
                    break;
                }
                else if (commands[0] == "Even")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 == 0)
                        {
                            Console.Write(nums[i] + " ");
                        }
                    }
                    break;
                }
            }

        }
    }
}
