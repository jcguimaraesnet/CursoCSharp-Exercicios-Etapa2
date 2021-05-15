using System;

namespace TempoParaAposentadoria
{
    class Program
    {
        static void Main(string[] args)
        {
            const sbyte idadeParaAPosentadoria = 65;
            Console.WriteLine("Informe a sua idade atual:");
            var idade = sbyte.Parse(Console.ReadLine()); //ou Convert.ToSByte(Console.ReadLine());

            var anosQueFaltamParaAposentadoria = idadeParaAPosentadoria - idade;
            Console.WriteLine($"Faltam {anosQueFaltamParaAposentadoria} para sua aposentadoria.");
        }
    }
}
