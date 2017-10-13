using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            

            int startOfCurrSeq = 0;
            int lenghtOfCurrSeq = 1;
            int startOfLongestSeq = 0;
            int lenghtOfLongestSeq = 1;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    lenghtOfCurrSeq++;
                    if (lenghtOfCurrSeq > lenghtOfLongestSeq)
                    {
                        lenghtOfLongestSeq = lenghtOfCurrSeq;
                        startOfLongestSeq = startOfCurrSeq;
                    }
                }
                else
                {
                    lenghtOfCurrSeq = 1;
                    startOfCurrSeq = i;
                }
            }

            for (int i = startOfLongestSeq; i < startOfLongestSeq + lenghtOfLongestSeq; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
