using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_clases.Models
{
    public class Calculadora
    {
        public int Sumar(int a, int b){
            var suma = a + b;
            return suma;
        }

        public int Restar(int a, int b){
            var resta = a - b;
            return resta;
        }
    }
}