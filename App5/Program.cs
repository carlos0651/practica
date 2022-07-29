using System;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingres otro numero");
            int num2 = int.Parse(Console.ReadLine());
            var suma = num1 + num2;
            var resta = num1 - num2;
            var multiplicacion = num1 * num2;
            var division = num1 / num2;

            Console.WriteLine("La suma de los numeros es: {0}", suma);
            Console.WriteLine("La suma de los numeros es: {0}", resta);
            Console.WriteLine("La suma de los numeros es: {0}", multiplicacion);
            Console.WriteLine("La suma de los numeros es: {0}", division);
    }
}
