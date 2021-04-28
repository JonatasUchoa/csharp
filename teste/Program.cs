using System;

namespace teste
{
    class Program
    { 

        static void Main(string[] args)
        {
            Console.WriteLine("escreva o seu nome:");
            string nome = Console.ReadLine();

            if (nome == null || string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("nome não informado para seguir no progama");
                return;
            }

            Console.WriteLine("irforme sua idade: ");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);
            if (idadeInformada == false)
            {
                Console.WriteLine("informe a idade válida para continuar");
                return;
            }

            bool estaConvidado;

            switch (nome)
            {
                case "Mateus":
                    estaConvidado = true;
                    break;
                case "Carlos":
                    estaConvidado = true;
                    break;
                case "João":
                    estaConvidado = true;
                    break;
                case "José":
                    estaConvidado = true;
                    break;
                case "Maria":
                    estaConvidado = true;
                    break;
                default:
                    estaConvidado = false;
                    break;
            }

            if(estaConvidado == true && idade > 18)
            {
                Console.WriteLine("Parabéns pode aproveitar a festa");
            }
            else
            {
                Console.WriteLine("que pena! você não possui os critérios necessários para entrar(está convidado e ser maior)");
            }
        }
    }
}
