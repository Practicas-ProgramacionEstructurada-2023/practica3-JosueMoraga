using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            //Declaracion de variables

            string? marcaZapato;
            string? colorZapato;
            int cantidad;
            double precioZapato;

            //Capturando datos

            Console.WriteLine("\n----------- Capturando variables -----------\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese la marca de zapatos a comprar: ");
            marcaZapato = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nIngrese el color del par de zapatos: ");
            colorZapato = Convert.ToString(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nIngrese la cantidad de pares de zapatos a comprar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese el precio del par de zapatos a comprar: ");
            precioZapato = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("----------- Fin de variables -----------\n");

            //Capturar el total a pagar

            double total = cantidad*precioZapato;

            //Imprimiendo resultado
            Console.WriteLine("\n----------- Imprimiendo resultados -----------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("La marca de zapatos a comprar es: " + marcaZapato);
            Console.WriteLine("\nEl color de los zapatos a comprar es: " + colorZapato);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLa cantidad de pares de zapatos a comprar es: " + cantidad);
            Console.WriteLine("\nEl precio del par de zapatos a comprar es: " + precioZapato);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nEl total a pagar es: " + total);
            Console.ResetColor();
            Console.WriteLine("----------- Fin de imprimir resultados -----------\n");
            


        }
    }
}