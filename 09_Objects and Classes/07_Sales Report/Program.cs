using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];

            for (int i = 0; i < sales.Length; i++)
                sales[i] = ReadSale();

            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                decimal totalSales = sale.Price * sale.Quantity;
                if (salesByTown.ContainsKey(sale.Town))
                {
                    salesByTown[sale.Town] += totalSales;
                }
                else
                {
                    salesByTown.Add(sale.Town, totalSales);
                }
            }
            foreach (var keyvaluePair in salesByTown)
            {
                Console.WriteLine($"{keyvaluePair.Key} -> {keyvaluePair.Value:F2}");
            }
        }

        public static Sale ReadSale()
        {
            string[] input = Console.ReadLine().Split();
            Sale sale = new Sale() { Town = input[0], Product = input[1], Price = decimal.Parse(input[2]), Quantity = decimal.Parse(input[3]) };
            return sale;
        }

        public class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }

        }
    }
}
