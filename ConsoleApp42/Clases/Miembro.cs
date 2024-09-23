using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp42.Clases
{
    public class Miembro
    {
        private string _nombre;
        private int _id;
        private string _fechaRegistro;

        public Miembro(string nombre, int id, string fechaRegistro)
        {
            _nombre = nombre;
            _id = id;
            _fechaRegistro = fechaRegistro;
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Id
        { get { return _id; } set {
                _id = value; } 
        }
        public string FechaRegistro 
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }
    
    }
   
}
