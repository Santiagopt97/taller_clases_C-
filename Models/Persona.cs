using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_clases.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre.ToLower();
            this.Edad = edad;
        }
        
        public void Saludar(){
            Console.WriteLine($"Hola, mi nombre es {Nombre}");
        }

        public void MostrarDetalles(){
            Console.WriteLine($"Hola: {Nombre} tienes: {Edad}");
        }
    }
}