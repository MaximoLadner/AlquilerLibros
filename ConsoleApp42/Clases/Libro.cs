using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42.Clases
{
    public class Libro
    {
        private string _titulo;
        private string _autor;
        private int _codigo;
        private int _stock;
        public Libro(string titulo, string autor, int codigo, int stock)
        {
            _titulo = titulo;
            _autor = autor;
            _codigo = codigo;
            _stock = stock;
            
        }
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        public string Autor 
        { 
            get { return _autor; }
            set { _autor = value; } 
        }
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public void MostrardetallesLibros()
        {
            Console.WriteLine($"Tiulo: {Titulo}\nAutor: {Autor}\nCodigo: {Codigo}\nStock: {Stock}");
        }
    }
}
