using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables 
            string firstname = "Carlos";
            String Lastname = "Gomez";
            int edad = 19;
            //Concatenación de variables 
            var name = firstname + " " + Lastname;
            //Imprimir de variables dentro de texto 
            Console.WriteLine("Su nombre es: {0} y su edad es {1}", name, edad);
        }
    }
}
