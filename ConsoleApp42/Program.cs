using ConsoleApp42.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = new List<Libro>
            {
                new Libro("Las Aventuras de Ladner","Maximo Ladner",1,4),
                new Libro ("Las aventuras de Pasita","Bianca Pasarelli",2,1),
                new Libro ("Las aventuras de Garrone","Santino Garrone",3,5)
            };
            string eleccion = "";
            while (eleccion != "salir")
            {
                 Console.WriteLine("Eres miembro de la biblioteca?(si,no,salir): ");
                 eleccion = Console.ReadLine();
                if (eleccion == "si" || eleccion == "Si")
                {
                    Console.WriteLine("bienvenido señor");
                    Thread.Sleep(1000);
                    Console.Clear();

                    Console.WriteLine("Estos son los libros que hay para que alquiles: ");
                    foreach (var libro in libros)
                    {
                        libro.MostrardetallesLibros();
                        Console.WriteLine("__________________________________________");
                    }
                    Console.WriteLine("Que libros quieres llevarte prestado(titulo)?");
                    string elecion = Console.ReadLine();
                    eleccion.ToLower();

                    foreach (var libro in libros)
                    {
                        if (elecion == libro.Titulo)
                        {
                            Prestamo prestamito = new Prestamo("23/9/2024", "30/9/2024", libro);
                            if(libro.Stock > 0)
                            {
                                Console.WriteLine("Ya se ha generado un prestamo para el libro " + libro.Titulo);
                                libro.Stock -= 1;
                            }
                            else
                            {
                                Console.WriteLine("No hay stock suficiente disculpe");
                            }
                        }
                    }
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                
            }
        }
    }
}
