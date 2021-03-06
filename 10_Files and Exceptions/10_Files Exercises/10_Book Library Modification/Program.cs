﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            List<Book> listOfBooks = new List<Book>();
            Dictionary<string, DateTime> results = new Dictionary<string, DateTime>();

            string[] input = File.ReadAllLines("input.txt");

            var booksCount = int.Parse(input[0]);

            for (int i = 0; i < booksCount; i++)
            {
                string[] inputLines = input[i + 1].Split(' ');
                listOfBooks.Add(new Book { Title = inputLines[0], Author = inputLines[1], Publisher = inputLines[2], ReleaseDate = DateTime.ParseExact(inputLines[3], "d.MM.yyyy", CultureInfo.InvariantCulture), ISBN = inputLines[4], Price = decimal.Parse(inputLines[5]) });
            }
            Library library = new Library() { Name = "Kostadin's Library", ListOfBooks = listOfBooks };

            DateTime inputDate = DateTime.ParseExact(input.Last(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in library.ListOfBooks)
            {
                if (book.ReleaseDate > inputDate)
                {
                    results.Add(book.Title, book.ReleaseDate);
                }
            }
            results = results.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            List<string> output = new List<string>();

            foreach (var item in results)
            {
                output.Add($"{item.Key} -> {item.Value.ToString("dd.MM.yyyy")}");
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
