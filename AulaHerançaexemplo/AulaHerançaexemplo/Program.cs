using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AulaHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassePessoa pessoa1 = new ClassePessoa();
            ClasseAluno pessoa2 = new ClasseAluno();
            ClasseProfessor pessoa3 = new ClasseProfessor();
            ClasseFuncionario pessoa4 = new ClasseFuncionario();
            ClasseProfessor pessoa5 = new ClasseProfessor();


            pessoa1.setNome("Luis");
            pessoa1.setIdade(30);
            pessoa2.setNome("Maria");
            pessoa2.setCurso("TI");
            pessoa3.setNome("Luisa");
            pessoa3.setSalario(3000.50f);
            pessoa4.setNome("João");
            pessoa4.setSexo("Masculino");
            pessoa4.setTrabalhando(false);
            pessoa5.setNome("Caio");
            pessoa5.setIdade(35);
            pessoa5.setSexo("Masculino");
            pessoa5.setEspecialidade("Word");
            pessoa5.setSalario(2500.68f);

            Console.WriteLine(pessoa1.ToString());
            Console.WriteLine(pessoa2.ToString());
            Console.WriteLine(pessoa3.ToString());
            Console.WriteLine(pessoa4.ToString());
            Console.WriteLine(pessoa5.ToString());


            Console.ReadKey();





        }
    }
}
