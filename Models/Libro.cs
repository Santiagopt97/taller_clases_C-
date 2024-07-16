using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace taller_clases.Models
{
    public class Libro
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Texto { get; set; }

        public Libro(string titulo, string autor, string texto)
        {
            this.Titulo = titulo.ToUpper();
            this.Autor = autor;
            this.Texto = texto.ToLower();
        }

        public int ContarPalabras(string texto){
            int contador = texto.Length;
            return contador; 
        }
    }
}