using System;

namespace ConsoleApp1  // Cambia el nombre del namespace para reflejar el nombre del proyecto de consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor ingrese un número: "); // Pedir al usuario que ingrese un número
            string entrada = Console.ReadLine(); // Leer la entrada como string 

            try
            {
                double n = double.Parse(entrada); // Convertir la entrada de string a double
                Console.WriteLine("Número ingresado: " + n);

                if (n > 10)
                    Console.WriteLine("Es mayor a 10");
                else
                    Console.WriteLine("No es mayor a 10");
            }
            catch (FormatException)
            {
                Console.WriteLine("La entrada no es un número válido.");
            }
        }
    }
}
