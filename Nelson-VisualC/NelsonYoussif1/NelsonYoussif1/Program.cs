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
            string nome;
            string cidade;
            int idade;

          Console.Write("Digite o seu nome: ");
          nome = Console.ReadLine();

          Console.Write("Digite a sua Cidade: ");
          cidade = Console.ReadLine();


          Console.Write("Digite a sua Idade: ");
          idade = int.Parse(Console.ReadLine());


          Console.WriteLine("O seu Nome é: " +  nome);
          Console.WriteLine(" A sua  Cidade é: " + cidade);
          Console.WriteLine(" A sua Idade é: " + idade);



          Console.ReadKey();


        }
    }
}
