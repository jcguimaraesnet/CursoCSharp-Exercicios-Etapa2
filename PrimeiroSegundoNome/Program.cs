using System;

namespace PrimeiroSegundoNome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu primeiro nome:");
            var primeiroNome = Console.ReadLine();

            Console.WriteLine("Informe o seu segundo nome:");
            var segundoNome = Console.ReadLine();

            Console.Write($"Seu nome completo é: {primeiroNome} {segundoNome}");

        }
    }
}
