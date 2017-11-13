using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



class AnonymousCache
{
    static void Main()
    {
        
        List<Dataset> dataSets = new List<Dataset>();
        List<string> dataSetNames = new List<string>();

        Dictionary<string, long> cache = new Dictionary<string, long>();

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "thetinggoesskrra")
                break;

            string[] commandTokens = Regex.Split(command, " -> ");

            if (commandTokens.Length <= 1)
            {
                var dataSetName = commandTokens[0];
                dataSets.Add(new Dataset { Name = dataSetName});
                dataSetNames.Add(dataSetName);
            }
            else
            {
                var dataKey = commandTokens[0];
                string[] dataSizeAndDataSet = commandTokens[1].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var dataSize = long.Parse(dataSizeAndDataSet[0]);
                var dataSetName = dataSizeAndDataSet[1];

                var newDataSet = new Dataset { Name = dataSetName,  DataKey = dataKey, DataSize = dataSize};

                foreach (var dataSet in dataSets)
                {
                    if (!(dataSetNames.Contains(dataSetName)))
                    {
                        dataSets.Add(newDataSet);
                        dataSetNames.Add(dataSetName);
                    }
                    else
                    {
                        dataSet.DataKeys.Add(dataKey);
                        dataSet.DataSizes.Add(dataSize);
                    }
                }
            }
        }
    }

    public class Dataset
    {
        public string Name { get; set; }
        public long DataSize { get; set; }
        public string DataKey { get; set; }
        public List<string> Names = new List<string>();
        //public Dictionary<string, long> dictionary = new Dictionary<string, long>();
        public List<string> DataKeys { get; set; }
        public List<long> DataSizes { get; set; }
    }
}

