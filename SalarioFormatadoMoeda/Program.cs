using System;
using System.Globalization;

namespace SalarioFormatadoMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu salário:");
            var salario = decimal.Parse(Console.ReadLine()); //ou Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Seu salário formatado: {salario:C2}");
            Console.WriteLine("Seu salário formatado: " + salario.ToString("C2"));
            Console.WriteLine("Seu salário formatado: " + salario.ToString("C2", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine("Seu salário formatado: {0:C2}", salario);
        }
    }
}
