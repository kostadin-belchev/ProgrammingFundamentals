using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Order> listOfOrders = new List<Order>();

            for (int i = 0; i < N; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime dateEntered = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());
                listOfOrders.Add(new Order { PricePerCapsule = pricePerCapsule, Date = dateEntered, CapsulesCount = capsulesCount});
            }

            decimal totalPrice = 0M;

            foreach (var order in listOfOrders)
            {
                totalPrice += order.OrderPrice;
            }

            for (int i = 0; i < listOfOrders.Count; i++)
            {
                Console.WriteLine($"The price for the coffee is: ${listOfOrders[i].OrderPrice:F2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }

    public class Order
    {
        public decimal PricePerCapsule { get; set; }
        public DateTime Date { get; set; }
        public long CapsulesCount { get; set; }
        public decimal OrderPrice
        {
            get
            {
                int daysInMonth = System.DateTime.DaysInMonth(Date.Year, Date.Month);
                return (daysInMonth * CapsulesCount) * PricePerCapsule;
            }
        }
    }
}
