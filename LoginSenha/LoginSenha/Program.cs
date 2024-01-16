using System;
using System.Reflection.Metadata;

namespace LoginSenha
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo Ao Sistema Testes de Conhecimento!");
            Console.WriteLine("Para começarmos, primeiro vamos precisar que você faça um registro em nossos sistemas!");
            Console.Write("Digite um nome de Usuário: ");
            string username = Console.ReadLine();
            int caracteres = username.Count();

            while (caracteres > 16 || caracteres <= 0 || caracteres < 6) {
                Console.WriteLine("Número de caracteres inválido! Permitido no máximo 16 caracteres e no mínimo 6");
                Console.Write("Digite um nome de Usuário: ");
                username = Console.ReadLine();
                caracteres = username.Count();
            }
            
            Console.Write("Digite um email: ");
            string email = Console.ReadLine().ToLower(); ;
            string[] validar = email.Split('@');
            bool teste = ValidarEmail(validar[1]);
            while (teste != true)
            {
                Console.WriteLine("Email inválido! Digite um email válido!");
                Console.Write("Digite um email válido: ");
                email = Console.ReadLine().ToLower(); ;
                validar = email.Split('@');
                teste = ValidarEmail(validar[1]);
            }

            Console.Write("Digite uma senha: ");
            String password = Console.ReadLine();
            string validarSenha = FiltroSenha(password);
            while (validarSenha != "sv")
            {
                Console.WriteLine("Por favor, digite uma senha que possua caracteres especiais e possua mais que 6 caracteres.");
                Console.Write("Digite uma senha: ");
                password = Console.ReadLine();
                validarSenha = FiltroSenha(password);
            }

        }
        static bool ValidarEmail(string email)
        {
            bool ok = false;
            string[] filter = ["gmail.com", "hotmail.com", "outlook.com"];
            foreach (string s in filter) {
               if (s.Contains(email))
                {
                    ok = true;
                }              
            }
            return ok;
        }
        static string FiltroSenha(string senha)
        {
            string[] caracteresEspeciais = ["/", ".", "@", "!", "#", "$", "¨", "&", "*", "(", ")", "'", ",", "-", "_", "=", "+", "´","?", ":",";","|"];
            string ok = "";
            int valor = senha.Count();
            foreach (string c in caracteresEspeciais)
            {
                if (c.Contains(senha) && valor > 6)
                {
                    ok = "sv"; // SV = Senha valida
                } else if (c.Contains(senha) && valor < 6)
                {
                    ok = "pc"; // PC = Poucos caracteres
                } else
                {
                    ok = "sc"; // SC = Sem caracteres especiais
                }
            }
            return ok;
        }
        static string RemoverEspacos(string texto)
        {
            texto = texto.Replace(" ", "");
            return texto;
        }
    }
}