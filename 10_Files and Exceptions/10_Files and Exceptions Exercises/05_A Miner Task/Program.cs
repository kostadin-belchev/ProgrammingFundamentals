using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt")
                .ToArray();

            int index = 0;
            string resource = input[index++];
            var listOfResources = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(input[index++]);

                if (!listOfResources.ContainsKey(resource))
                {
                    listOfResources[resource] = 0;
                }
                listOfResources[resource] += quantity;

                resource = input[index++];
            }
            var outputResources = new List<string>();

            foreach (var keyValuePair in listOfResources)
            {
                outputResources.Add($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }

            File.WriteAllLines("output.txt", outputResources);
        }
    }
}
