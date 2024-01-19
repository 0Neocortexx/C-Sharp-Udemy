using System;

namespace Testes
{
	class Program
	{
        static void Main(string[] args)
        {
            string[] filtro = ["@gmail.com", "@hotmail.com", "@outlook.com"];
            foreach (string filtroItem in filtro)
            {
                Console.WriteLine(filtroItem);
            }
        }
    }
}