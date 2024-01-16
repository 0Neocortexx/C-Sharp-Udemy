using System;
using System.ComponentModel;
using System.Globalization;

namespace EntradaDeDados2
{
	class Program
	{
        static void Main(string[] args)
        {
            // O console.readline sempre lerá os dados em string
            // int n1 = int.Parse(Console.ReadLine());
            // char ch = char.Parse(Console.ReadLine());
            // double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Console.WriteLine(n1);
            // Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            // Console.WriteLine(ch);
            // string[] var = Console.ReadLine().Split(' ');
            // string nome = var[0];
            // char sexo = char.Parse(var[1]);
            // int idade = int.Parse(var[2]);
            // double altura = double.Parse(var[3], CultureInfo.InvariantCulture);
            // Console.WriteLine("Nome: " + nome + ", Sexo: " + sexo + ", Idade: " + idade +  ", Altura: " + altura);

            Console.WriteLine("Exercicio proposto!");
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (Mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}