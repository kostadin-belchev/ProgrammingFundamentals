using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            string command = Console.ReadLine();

            List<int> results = new List<int>();

            while (command != "print")
            {
                string[] commands = command.Split(' ');
                if (commands[0] == "add")
                {
                    int index = int.Parse(commands[1]);
                    long element = long.Parse(commands[2]);
                    nums.Insert(index, element);
                }
                else if (commands[0] == "addMany")
                {
                    int insertIndex = int.Parse(commands[1]);
                    List<long> listOfLongsToInsert = commands.Skip(2).Select(long.Parse).ToList();
                    nums.InsertRange(insertIndex, listOfLongsToInsert);
                }
                else if (commands[0] == "contains")
                {
                    long elementToSearch = long.Parse(commands[1]);
                    if (nums.Contains(elementToSearch))
                    {
                        int foundAtIndex = nums.IndexOf(elementToSearch);
                        Console.WriteLine(foundAtIndex);
                    }
                    else
                        Console.WriteLine("-1");
                }
                else if (commands[0] == "remove")
                {
                    int indexOfElemToBeRemoved = int.Parse(commands[1]);
                    nums.RemoveAt(indexOfElemToBeRemoved);

                }
                else if (commands[0] == "shift")
                {
                    int positionsToBeShifted = int.Parse(commands[1]);
                    //nums = Shift(positionsToBeShifted, nums);
                    for (int i = 0; i < positionsToBeShifted; i++)
                    {
                        long lastElement = nums[0];
                        for (int j = 0; j < nums.Count - 1; j++)
                        {
                            nums[j] = nums[j + 1];
                        }
                        nums[nums.Count - 1] = lastElement;
                    }
                }
                else if (commands[0] == "sumPairs")
                {
                    List<long> sumList = new List<long>();
                    for (int i = 0; i < nums.Count - 1; i += 2)
                    {
                        sumList.Add(nums[i] + nums[i + 1]);
                    }
                    if (nums.Count % 2 == 1)
                    {
                        sumList.Add(nums[nums.Count - 1]);
                    }
                    nums = sumList;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("["+ string.Join(", ", nums) + "]");
        }

        //public static List<long> Shift(int positions, List<long> list)
        //{
        //    return list.Skip(positions).Concat(list.Take(positions)).ToList();
        //}
    }
}
