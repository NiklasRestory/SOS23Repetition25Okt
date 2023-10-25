using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SOS23Library20Oktober
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public List<string> Reviews { get; set; }

        private static int BookCount = 0;

        public Book(string title, string author, int pageCount, List<string> reviews)
        {
            BookCount++;
            Title = title;
            Author = author;
            PageCount = pageCount;
            Reviews = reviews;
        }

        public static int GetBookCount()
        {
            return BookCount;
        }
    }
    // Let's do a conflict.
}
