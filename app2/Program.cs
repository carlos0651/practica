using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 9;
            int num2 = 17;
            var suma = num1 + num2;
            int edad = 19;
            string name = "Carlos";

            Console.WriteLine(suma);
            Console.WriteLine("Su nombre es: {0} y su edad es {1}", name, edad);
        }
    }
}
