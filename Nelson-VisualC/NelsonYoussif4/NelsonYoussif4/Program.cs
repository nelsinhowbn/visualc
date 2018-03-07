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

            double a, b, c, resultado;


            Console.Write("Digite o Valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o Valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o Valor de C: ");
            c = double.Parse(Console.ReadLine());

            resultado = Math.Pow(a, 2) * 5 - c / (b - a % 4);

            Console.WriteLine(" O resultado será: " + resultado);




            
            
            
            
            
            
            
            Console.ReadKey();










        }
    }
}
