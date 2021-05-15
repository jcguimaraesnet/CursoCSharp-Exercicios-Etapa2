using System;

namespace LaranjaGratuita
{
    class Program
    {
        static void Main(string[] args)
        {
            const double valorLaranjaUnitaria = 1.50;

            Console.WriteLine("Informe a quantidade de laranjas que deseja levar:");
            var quantidadeLaranjas = int.Parse(Console.ReadLine());
            quantidadeLaranjas--;

            var valorTotal = valorLaranjaUnitaria * quantidadeLaranjas;

            Console.WriteLine($"Quantidades de laranjas a pagar: {quantidadeLaranjas}");
            Console.WriteLine($"Valor total : {valorTotal:C2}");
            Console.WriteLine("Você ganhou uma laranja gratuitamente. ");
        }
    }
}
