using System;
using System.Text;
using System.Linq;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author1 = new Author("Jack London", new DateTime(1930, 2, 2));

            Book book1 = new Book("White Fang", 1940, author1);

            Author author2 = new Author("I. Ilf", new DateTime(1907, 1, 1));
            Author author3 = new Author("E. Petrov", new DateTime(1903, 3, 3));

            Book book2 = new Book("12 Chairs", 1925, new Author[] { author2, author3 });

            Library library = new Library();

            library.Add(new Book[] { book1, book2 });

            Book search1 = library.SearchByTitle("white fang");

            Book[] search2 = library.Search("white");

            Book[] search3 = library.SearchByAuthor("e. petrov");

        }
    }
}
