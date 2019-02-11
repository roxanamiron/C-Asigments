using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
   public class Library
    {
        public List<Book> books = new List<Book>();
        private string Name { get; set; }

        public string AddBooks(string name, string author, string publisher, string releaseDate, long isbn)
        {
           
            books.Add(new Book(name, author, publisher, releaseDate, isbn));
            return books.ToList().ToString();     
        }
        public Book SearchForABook(string author)
        {
            var result = books.Find(b => b.Author == author);
            return result;
        }
        public void DisplayInfo()
        {
            foreach(var book in books)
            {
                Console.WriteLine("\nTitle: " + book.BookName + "\nAuthor: " +book.Author + "\nPublisher: " +book.Publisher + "\nRelease Date: " + book.ReleaseDate + "\nISBN Number: " + book.IsbnNumber);
            }
        }
        public void DeleateBook(string name)
        {
            books.Remove(new Book(name));
        }
    }
}
