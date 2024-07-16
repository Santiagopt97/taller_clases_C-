using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_clases.Models
{
    public class Coche
    {
        public string? Marca { get; set; }
        public int Modelo { get; set; }
        public int Año { get; set; }


        public void MostrarDetalles(){
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}");
        }

        public void NuevoAño(int año){
            Año = año;
            Console.WriteLine($"El año del coche ha sido actualizado a: {Año}");
        }
    }
}