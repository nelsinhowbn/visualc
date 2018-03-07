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
            int idade;
            Console.Write("Digite a sua Idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade < 18)
            {
                Console.WriteLine("Você é menor de Idade");
            }
            else
            {
                Console.WriteLine("Você é maior de Idade");
            }




            Console.ReadKey();




        }
    }
}
