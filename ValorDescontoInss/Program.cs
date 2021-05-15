using System;

namespace ValorDescontoInss
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal aliquotaInss = 0.08m;
            Console.WriteLine("Informe o seu salário:");
            var salario = decimal.Parse(Console.ReadLine()); //ou Convert.ToDecimal(Console.ReadLine());

            var valorDescontoInss = salario * aliquotaInss;
            Console.WriteLine($"O valor de desconto do inss sobre seu salário é: {valorDescontoInss:C2}");
        }
    }
}
