using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Andrey_and_Billiard
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> productsAndQuantity;
            public decimal Bill { get; set; }
        }

        static void Main(string[] args)
        {
            //Try Ctrl + K + D ;)
            int n = int.Parse(Console.ReadLine());

            var products = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split('-');
                var product = line[0];
                var price = decimal.Parse(line[1]);

                if (!products.ContainsKey())
                {

                }

                GetProductsAndPrices(products);

                string line2 = Console.ReadLine();
                List<Customer> customers = new List<Customer>();

                while (line2 != "end of clients")
                {
                    var info = line2.Split(new char[] { '-', ',' });

                    string name2 = info[0];
                    string product2 = info[1];
                    int quantity2 = int.Parse(info[2]);

                    if (products.ContainsKey(product))
                    {
                        Customer customer = new Customer();
                        customer.Name = name2;
                        customer.productsAndQuantity = new Dictionary<string, int>();
                        customer.productsAndQuantity.Add(product2, quantity2);
                        
                        if (customers.Any(x => x.Name == customer.Name))
                        {
                            var cust = customers.Where(x => x.Name == customer.Name).First();

                            cust.productsAndQuantity[product] += quantity2;
                            cust.Bill = custo;
                        }

                        customer.Bill = customer.Bill + products[product] * quantity2;

                        customers.Add(customer);
                    }
                    line2 = Console.ReadLine();
                }

                decimal totalBill = 0M;

                foreach (var c in customers.OrderBy(s => s.Name))
                {
                    Console.WriteLine(c.Name);
                    foreach (var productAndQuantity in products)
                    {
                        Console.WriteLine($"-- {}");
                    }
                }
            }
        }
    }
}
