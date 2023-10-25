using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS23Library20Oktober
{
    internal class Shelve
    {
        List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> GetBooks() 
        {
            return books;
        }
    }
}
