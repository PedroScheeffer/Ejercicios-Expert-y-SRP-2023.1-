using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {
        private List<Book> books = new List<Book>();
        public string name {get; set;}
        public Shelve(string name){
            this.name = name;
        }
        public void addBook(Book book)
        {
            books.Add(book);
        }
        public void removeBook(Book book)
        {
            books.Remove(book);
        }

        internal Book buscarPorAutor(string entrada)
        {
            foreach (var book in books)
            {
                if(book.Author == entrada){
                    return book;
                }
            }   
            return null;
        }

        internal Book buscarPorCodigo(string entrada)
        {
            foreach (var book in books)
            {
                if(book.Code == entrada){
                    return book;
                }
            }   
            return null;
        }

        internal Book buscarPorNombre(string entrada)
        {
            foreach (var book in books)
            {
                if(book.Title == entrada){
                    return book;
                }
            }   
            return null;
        }
    }
}
