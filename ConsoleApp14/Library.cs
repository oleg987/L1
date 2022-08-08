using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Library
    {
        private Book[] _books;
        private string _address;

        public string Address { get => _address; set => _address = value; }
        public Book[] Books { get => _books; set => _books = value; }

        public Library()
        {
            _books = new Book[0];
        }

        public Library(string address) : this()
        {
            Address = address;
        }

        public Library(string address, Book[] books) : this(address)
        {
            Books = books;
        }

        public void Add(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);

            _books[_books.Length - 1] = book;
        }

        public void Add(Book[] books)
        {
            //foreach (Book book in books)
            //{
            //    Add(book);
            //}

            Array.Resize(ref _books, _books.Length + books.Length);

            Array.Copy(books, 0, _books, _books.Length - books.Length, books.Length);
        }

        public Book SearchByTitle(string search)
        {
            foreach (Book book in _books)
            {
                if (book.Title.ToUpper() == search.ToUpper())
                {
                    return book;
                }
            }

            return null;
        }

        public Book[] Search(string search)
        {
            Book[] result = new Book[0];

            foreach (Book book in _books)
            {
                if (book.Title.ToUpper().Contains(search.ToUpper()))
                {
                    Array.Resize(ref result, result.Length + 1);

                    result[result.Length - 1] = book;
                }
            }

            return result;
        }

        public Book[] SearchByAuthor(string search)
        {
            Book[] result = new Book[0];

            foreach (Book book in _books)
            {
                foreach (Author author in book.Authors)
                {
                    if (author.FullName.ToUpper() == search.ToUpper())
                    {
                        Array.Resize(ref result, result.Length + 1);

                        result[result.Length - 1] = book;

                        break;
                    }
                }
            }

            return result;
        }
    }
}
