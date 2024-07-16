using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_clases.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            this.Nombre = nombre.ToLower();
            this.Precio = precio;
        }

        public string GetNombre(){
            return Nombre;
        }

        public string SetNombre(string nombre){
            return Nombre = nombre;
        }
    }
}