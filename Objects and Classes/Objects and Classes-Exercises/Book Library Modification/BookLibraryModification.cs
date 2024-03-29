﻿namespace Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class BookLibraryModification
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Book> listOfBooks = new List<Book>();


            for (int i = 1; i <= n; i++)
            {
                var token = Console.ReadLine().Split(' ').ToArray();

                Book book = CreateBook(token);
                listOfBooks.Add(book);
            }

            var dateTime = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Library library = new Library() { Name = "IVAN PETROV", Books = listOfBooks };

            Dictionary<string, DateTime> result = SortByRealeaseAndTitle(library, dateTime);

            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value.ToString("dd.MM.yyyy"));
            }
        }

        public static Book CreateBook(string[] token)
        {
            Book book = new Book();

            book.Title = token[0];
            book.Author = token[1];
            book.Publisher = token[2];
            book.ReleaseDate = DateTime.ParseExact(token[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.ISBNnumber = int.Parse(token[4]);
            book.Price = double.Parse(token[5]);

            return book;
        }

        public static Dictionary<string, double> SortByAuthorAndPrice(Library library)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();
            var listToSorted = library.Books;

            foreach (var book in listToSorted)
            {
                if (!result.ContainsKey(book.Author))
                {
                    result[book.Author] = book.Price;
                }
                else
                {
                    result[book.Author] += book.Price;
                }
            }

            var printResult = result.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            return printResult;
        }

        public static Dictionary<string, DateTime> SortByRealeaseAndTitle(Library library, DateTime dateTime)
        {
            Dictionary<string, DateTime> result = new Dictionary<string, DateTime>();

            var books = library.Books;

            foreach (var book in books)
            {
                if (book.ReleaseDate > dateTime)
                {
                    result[book.Title] = book.ReleaseDate;
                }
            }

            var sortedResult = result.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            return sortedResult;
        }
    }
}
