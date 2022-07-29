using System;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("introduzca un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca otro numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma entre los numeros es: " + (num1 + num2));
            Console.WriteLine("La resta entre los numeros es: " + (num1 - num2));
            Console.WriteLine("La multiplicacion entre los numeros es: " + (num1 * num2));
            Console.WriteLine("La division entre los numeros es: " + (num1 / num2));
        }
    }
}
