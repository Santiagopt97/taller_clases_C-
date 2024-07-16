using Microsoft.VisualBasic;
using taller_clases.Models;

/* //dar valores a los atributos
var persona = new Persona();
persona.Nombre = "Juan";
persona.Edad = 25;
Console.WriteLine($"Hola: {persona.Nombre}, tienes {persona.Edad}");

//usar metodo saludar()
var persona1 = new Persona();
persona1.Nombre = "Maria";
persona1.Edad = 12;
persona1.Saludar(); */

//usando el constructor, al usar el constructor todas las instancias de la clase Persona deben llevar valores en sus parametros
var persona2 = new Persona("Santiago", 26);
Console.WriteLine($"Hola: {persona2.Nombre}, tienes {persona2.Edad}");

persona2.MostrarDetalles();

//Iniciamos con las instancias de coche
var coche = new Coche();
coche.Marca = "Mazda";
coche.Modelo = 2020;
coche.Año = 2021;

Console.WriteLine($"carro {coche.Marca} modelo {coche.Modelo} año {coche.Año}");

//usando el metodo MostrarDetalles()
var coche1 = new Coche();

coche1.Marca = "Ford";
coche1.Modelo = 2015;
coche1.Año = 2020;

coche1.MostrarDetalles();

//usando el metodo NuevoAño()
coche1.NuevoAño(2022);
coche1.MostrarDetalles();

//Usando la clase Libro
var libro = new Libro("El Señor de los Anillos", "J.R.R. Tolkien", "");
Console.WriteLine($"Libro: {libro.Titulo} escrito por: {libro.Autor}");

//usando el metodo ContarPalabras()
string texto = "Hola mundo";
Console.WriteLine($"El texto {texto}: tiene {libro.ContarPalabras(texto)} palabras");

//usando la clase Calculadora

Calculadora calculadora = new Calculadora();
int a = 5, b = 10, c=2;

//Usando el metodo Sumar()

Console.WriteLine($"la suma de los numeros {a} + {b} es igual a: {calculadora.Sumar(a,b)}");

//usando el metodo Restar()
Console.WriteLine($"la resta de los numeros {b} - {c} es igual a: {calculadora.Restar(b,c)}");

//usando la clase Producto

Producto producto = new Producto("Laptop", 2500.0);
Console.WriteLine($"El producto {producto.Nombre} tiene un valor de: {producto.Precio} COP" );

//Usando los metodos GetNombre() y SetNombre()

producto.SetNombre("Mouse");
Console.WriteLine($"El producto ahora se llama: {producto.GetNombre()}");
Console.WriteLine($"El producto {producto.Nombre} tiene un valor de: {producto.Precio} COP" );

//Usando la clase CuentaBancaria

var cuenta = new CuentaBancaria();
//Usando el metodo Depositar()
cuenta.Depositar(5000);
cuenta.Depositar(10000);
