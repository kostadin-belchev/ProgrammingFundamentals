using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Book> listOfBooks = new List<Book>();
            Dictionary<string, decimal> results = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] inputLines = Console.ReadLine().Split();
                listOfBooks.Add( new Book { Title = inputLines[0], Author = inputLines[1], Publisher = inputLines[2], ReleaseDate = DateTime.ParseExact(inputLines[3], "d.MM.yyyy", CultureInfo.InvariantCulture), ISBN = inputLines[4], Price = decimal.Parse(inputLines[5]) });

                //Code below sums total price of all books for a given Author
                //{
                //    decimal totalPriceBooks = 0M;
                //    if (!results.ContainsKey(listOfBooks[i].Author))
                //        results.Add(listOfBooks[i].Author, listOfBooks[i].Price);
                //    else
                //        totalPriceBooks += listOfBooks[i].Price;
                //} Console.WriteLine($"{book.Author} -> {book.Price}");
            }
            Library library = new Library() { Name = "Kostadin's Library", ListOfBooks = listOfBooks };
            //results = results.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var book in library.ListOfBooks)
            {
                if (!results.ContainsKey(book.Author))
                {
                    results.Add(book.Author, 0);
                }

                results[book.Author] += book.Price;
            }
            results = results.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var item in results)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }

        public class Library
        {
            public string Name { get; set; }
            public List<Book> ListOfBooks { get; set; }
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
        }
    }
}
