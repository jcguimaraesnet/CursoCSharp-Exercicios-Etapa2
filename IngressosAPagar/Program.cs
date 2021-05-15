using System;
using System.Globalization;
using System.Threading;

namespace IngressosAPagar
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");
            const double valorIngressoUnitario = 30.50;
            
            Console.WriteLine("Informe a quantidade de ingressos que deseja comprar:");
            var quantidadeIngressos = int.Parse(Console.ReadLine());

            var valorTotalIngressos = valorIngressoUnitario * quantidadeIngressos;

            Console.WriteLine($"Valor do ingresso unitário: {valorIngressoUnitario:C2}");
            Console.WriteLine($"Valor total dos ingressos: {valorTotalIngressos:C2}");
        }
    }
}
