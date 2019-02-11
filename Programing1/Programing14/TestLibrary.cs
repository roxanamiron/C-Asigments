using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
   public class TestLibrary
    {
        public void TestLibraryBooks()
        {
            Library library = new Library();
            library.AddBooks("Why I am so clever", "Nietzsche Friedrich", "Penguin", "martie 2016", 9780241251850);
            library.AddBooks("Love That Moves the Sun and Other Stars", "Dante Alighieri", "Penguin", "martie 2016", 9780241250426);
            library.AddBooks("Hamlet", "William shakespeare", "Wordsworth", "mai 1992", 1200200);
            library.AddBooks("The Odisey", "Homer", "Wordsworth", "mai 1992", 9781853260254);
            library.DisplayInfo();
            library.SearchForABook("Homer");
            library.DeleateBook("The Odisey");
            library.DisplayInfo();
            
        }
    }
}
