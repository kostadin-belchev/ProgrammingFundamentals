using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double differanceInPercetage = Percentage(lastPrice, currentPrice);
                bool isThereSignificantDifference = IsThereSignDiff(differanceInPercetage, threshold);

                string message = PrintMoveOfStock(currentPrice, lastPrice, differanceInPercetage, isThereSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string PrintMoveOfStock(double currentPrice, double lastPrice, double diffInPerentageFormat, bool isThereBigDiff)
        {
            string output = "";
            if (diffInPerentageFormat == 0)
            {
                output = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isThereBigDiff)
            {
                output = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, diffInPerentageFormat);
            }
            else if (isThereBigDiff && (diffInPerentageFormat > 0))
            {
                output = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, diffInPerentageFormat);
            }
            else if (isThereBigDiff && (diffInPerentageFormat < 0))
                output = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, diffInPerentageFormat);

            return output;
        }
        private static bool IsThereSignDiff(double threshold, double isDiff)
        {
            if (Math.Abs(threshold) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double Percentage(double last, double current)
        {
            double percentageResult = (current - last) / last;
            return percentageResult;
        }
    }
}
