using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double reais, dolar, cotacao;
            Console.Write("Digite o Valor em Reais: ");
            reais = double.Parse(Console.ReadLine());

            Console.Write("Digite a Cotação do Dolár: ");
            cotacao = double.Parse(Console.ReadLine());

            dolar = reais / cotacao;

            Console.WriteLine("O Valor em Dolár será: " + dolar);


            Console.ReadLine();

            



        }
    }
}
