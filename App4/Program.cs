using System;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir y almacenar datos de texto
            Console.WriteLine("Introduzca su nombre ");
            string name = Console.ReadLine();
            //pedir, convertir y almacenar datos numericos 
            Console.WriteLine("Introduzca su edad ");
            int edad = int.Parse(Console.ReadLine());
            //imprimir todos los datos 
            Console.WriteLine("Su nombre es: {0} y tiene {1} años de edad", name, edad);
        }
    }
}
