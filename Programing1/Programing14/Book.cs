using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
   public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public long IsbnNumber { get; set; }

        public Book(string name, string author, string publisher, string releaseDate, long isbn)
        {
            this.BookName = name;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.IsbnNumber = isbn;
        }
        public override string ToString()
        {
            return "\nTitle: " + BookName + "\nAuthor: " + Author + "\nPublisher: " + Publisher + "\nRelease Date: " + ReleaseDate + "\nISBN Number: " + IsbnNumber;
        }
        public Book(string name)
        {
            this.BookName = name;
        }

    }
}
