using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            List<Book> listOfBooks = new List<Book>();
            Dictionary<string, decimal> results = new Dictionary<string, decimal>();

            string[] input = File.ReadAllLines("input.txt");

            var booksCount = int.Parse(input[0]);

            for (int i = 0; i < booksCount; i++)
            {
                string[] inputLine = input[i + 1].Split(' ');
                listOfBooks.Add(new Book { Title = inputLine[0], Author = inputLine[1], Publisher = inputLine[2], ReleaseDate = DateTime.ParseExact(inputLine[3], "d.MM.yyyy", CultureInfo.InvariantCulture), ISBN = inputLine[4], Price = decimal.Parse(inputLine[5]) });
            }
            Library library = new Library() { Name = "Kostadin's Library", ListOfBooks = listOfBooks };

            foreach (var book in library.ListOfBooks)
            {
                if (!results.ContainsKey(book.Author))
                {
                    results.Add(book.Author, 0);
                }

                results[book.Author] += book.Price;
            }
            results = results.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            List<string> output = new List<string>();

            foreach (var item in results)
            {
                output.Add($"{item.Key} -> {item.Value:F2}");
            }
            File.WriteAllLines("output.txt", output);
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
