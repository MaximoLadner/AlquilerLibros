using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42.Clases
{
    public class Prestamo
    {
        private string _fechaLibroPrestado;
        private string _fechaDebeDevuelto;
        public Libro libro;
        public Prestamo(string fechaLibroPrestado, string fechaDebeDevuelto, Libro libro)
        {
            _fechaLibroPrestado = fechaLibroPrestado;
            _fechaDebeDevuelto = fechaDebeDevuelto;
            this.libro = libro;
        }
        public string FechaLibroPrestado
        {
            get {  return _fechaLibroPrestado;}
            set { _fechaLibroPrestado = value; }
        }
        public string FechaDebeDevuelto
        {
            get { return _fechaDebeDevuelto; }
            set { _fechaDebeDevuelto = value; }
        }
    }
}
