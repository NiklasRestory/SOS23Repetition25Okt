using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS23Library20Oktober
{
    internal class BookList
    {
        List<Book> bookList = new List<Book>();
        List<Shelve> shelves = new List<Shelve>();

        public BookList() 
        {
            List<string> reviews = new List<string>();
            reviews.Add("Good book.");

            Shelve basicShelf = new Shelve();
            // books = databaseConnection.GetBooks();
            AddBook(new Book("Happy Stars", "VV Klarkman", 100, reviews), basicShelf);
            AddBook(new Book("Sad Suns", "VV Klarkman", 50, reviews), basicShelf);
            AddBook(new Book("Golden Pathway", "Greg", 200, reviews), basicShelf);
            AddBook(new Book("Legend of Discord", "Lovisa", 44, reviews), basicShelf);
            Book book = new Book("I'm out of titles", "Joe", 84, reviews);
            AddBook(book, basicShelf);
            shelves.Add(basicShelf);
        }

        public void Menu()
        {
            ListAllBooks();

            Console.WriteLine("There are " + Book.GetBookCount() + " books in the library.");

            Console.WriteLine("Screen width is (not really but) " + Globals.screen_width);
            Console.WriteLine("Pythagoras Theorem between 2 and 2 is " + Globals.PythagorasTheorem(2, 2));

            Console.WriteLine("What book are you looking for?");
            string title = Console.ReadLine();
            Book book = FindBookByTitle(title);
            if (book == null)
            {
                Console.WriteLine("Book does not exist.");
            }
            else
            {
                Console.WriteLine("Found " + book.Title);
            }
        }

        public void PythagorasTheorem()
        {

        }

        public Book FindBookByTitle(string title)
        {
            foreach (Book book in bookList)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }
            return null;
        }

        public List<Book> FindAllBooksWithTitle(string title)
        {
            List<Book> books = new List<Book>();

            foreach (Book book in bookList)
            {
                if (book.Title == title)
                {
                    books.Add(book);
                }
            }

            return books;
        }

        public void ListAllBooks()
        {
            for(int i = 0; i < bookList.Count; i++)
            {
                Console.WriteLine("At index " + i + " we find the book " + bookList[i].Title);
            }
        }

        public void RemoveBook(Book book)
        {
            bookList.Remove(book);
        }

        public void AddBook(Book book, Shelve shelve)
        {
            Console.WriteLine("Adding the book " + book.Title + " by " + book.Author);
            bookList.Add(book);
            shelve.AddBook(book);
        }

        public void AddBook()
        {
            Console.WriteLine("What title?");
            string title = Console.ReadLine();
            List<string> reviews = new List<string>();
            bool oneMore = true;
            while (oneMore)
            {
                Console.WriteLine("One more? Write q to quit");
                string review = Console.ReadLine();
                if (review == "q")
                {
                    break;
                }
                reviews.Add(review);
            }

            Book vook = new Book(title, "", 0, reviews);
        }
    }
}
