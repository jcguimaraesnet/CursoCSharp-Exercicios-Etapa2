using System;

namespace SalarioLiquidoInssAtribuicaoReduzida
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal aliquotaInss = 0.08m;
            Console.WriteLine("Informe o seu salário:");
            var salario = decimal.Parse(Console.ReadLine()); //ou Convert.ToDecimal(Console.ReadLine());

            salario *= (1 - aliquotaInss);
            Console.WriteLine($"Seu salário líquido (após descontos) é: {salario:C2}");
        }
    }
}
