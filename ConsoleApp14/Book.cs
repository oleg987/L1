using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public Author[] Authors { get; set; }

        public Book(string title)
        {
            Title = title;
        }

        public Book(string title, int year) : this(title)
        {
            Year = year;
        }

        public Book(string title, int year, Author author) : this(title, year)
        {
            Authors = new Author[] { author };
        }

        public Book(string title, int year, Author[] authors) : this(title, year)
        {
            Authors = authors;
        }

        public Book(string title, int pages, string publisher, int year, Author[] authors) : this(title, pages)
        {
            Publisher = publisher;
            Year = year;
            Authors = authors;
        }
    }
}
