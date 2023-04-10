using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        private List<Shelve> shelves = new List<Shelve>();
        public string name  {get; set;}
        public Sector(string name){
            this.name = name;
        }
        public void addShelve(Shelve shelve)
        {
            shelves.Add(shelve);
        }
        public void removeShelve(Shelve shelve)
        {
            shelves.Remove(shelve);
        }
        public void shelveBook(Book book, string nombreShelveAGuardar){
            foreach (var shelve in shelves)
            {
                if(shelve.name == "nombreShelveAGuardar"){
                    shelve.addBook(book);
                }
            }
        }
        public Shelve getShelve(String name)
        {
            foreach (var shelve in shelves)
            {
                if(shelve.name == name){
                    return shelve;
                }
            }
            Console.Write("El shelve no existe");
            return null;
        }
        public Book getBookInteractivo()
        {
            Shelve shelveEnQueBuscar=null;
            Console.WriteLine("En que extante esta?");
            string entradaShelve = Console.ReadLine();
            foreach (var shelve in shelves)
            {
                if(shelve.name == entradaShelve){
                     shelveEnQueBuscar = shelve; 
                }
            }
            while (true)
            {
                Console.WriteLine("Elije porque desea buscar\n1. Nombre\n2. Autor\n3. Codigo\n4. salir");
                string entrada = Console.ReadLine();
                if(entrada == "1"){
                    Console.WriteLine("Escriba el Nombre");
                    entrada = Console.ReadLine();
                    return shelveEnQueBuscar.buscarPorNombre(entrada);
                }
                if(entrada == "2"){
                    Console.WriteLine("Escriba el Autor");
                    entrada = Console.ReadLine();
                    return shelveEnQueBuscar.buscarPorAutor(entrada);
                }
                if(entrada == "3"){
                    Console.WriteLine("Escriba el Codigo");
                    entrada = Console.ReadLine();
                    return shelveEnQueBuscar.buscarPorCodigo(entrada);
                }
                if (entrada == "4")
                {
                    return null;
                }
                Console.WriteLine("Ingrese algo valido");
            }
        }
    }
}