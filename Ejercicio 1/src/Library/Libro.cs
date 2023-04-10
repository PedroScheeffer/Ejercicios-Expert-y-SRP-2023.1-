using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        // Esto puede ser su propia clase
        // Se puede separar en Shelve y Sector
        /*
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        */
    }
}
