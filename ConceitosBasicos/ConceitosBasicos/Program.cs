using System;

namespace ConceitosBasicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041'; // Usando código unicode
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            float n5 = 4.5f; // Sempre com o F no final
            double n6 = 4.5;
            long n4 = 2147483648L; // Sempre com L no final
            string nome = "Maria"; //Sempre com aspas duplas
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;


            Console.WriteLine(letra);
            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int num1 = int.MinValue;
            Console.WriteLine(num1);
        }
    }
}