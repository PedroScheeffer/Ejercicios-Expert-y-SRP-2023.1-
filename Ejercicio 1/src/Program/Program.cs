using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Sector sectorA = new Sector("A");
            Shelve estante7 = new Shelve("7");
            Shelve estante3 = new Shelve("3");
            sectorA.addShelve(estante3);
            sectorA.addShelve(estante7);
            sectorA.shelveBook(book1,"7");
            sectorA.shelveBook(book2,"3");
            var libro = sectorA.getBookInteractivo();
            if(libro == null){
                Console.WriteLine("El libro es null");
            }
            else
            {
                Console.WriteLine(libro.Author);
            }

            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");
            
        }
    }
}