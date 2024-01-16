using System;

namespace EntradaDeDados
{
	class Program
	{
        static void Main(string[] args)
        {
            // Console.WriteLine("Digite Bom dia!");
            // string frase = Console.ReadLine();
            // Console.WriteLine("Você digitou: " + frase);

            string frutas = Console.ReadLine();
            string[] vetor = frutas.Split(' ');
            // string[] vetor = Console.ReadLine().Split(' '); da pra fazer assim tambem
            string fruta1 = vetor[0];
            string fruta2 = vetor[1];
            string fruta3 = vetor[2];

            Console.WriteLine(fruta1 + " " + fruta2 + " " + fruta3);
        }
    }
}