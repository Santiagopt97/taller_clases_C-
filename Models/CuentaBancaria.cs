using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_clases.Models
{
    public class CuentaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set;}

        public void Depositar(double cantidad){
            Saldo += cantidad;
            Console.WriteLine(@$"Se ha depositado: ${cantidad} en su cuenta.
Su saldo actual es de {Saldo}");
        } 
    }
}