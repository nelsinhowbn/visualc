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
            double numero, resultado;

            Console.Write("Digite o Número: ");
            numero = double.Parse(Console.ReadLine());
            resultado = Math.Pow(numero, 2);
            Console.WriteLine(" O resuldado do seu Número ao quadrado será: " + resultado);




            
            Console.ReadKey();









        }
    }
}
