using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaHerança
{
    class Program
    {
        static void Main(string[] args)
        {

            Empregado emp1 = new Empregado();
            Horista emp4 = new Horista();
            Comissionado emp6 = new Comissionado();
            Assalariado emp8 = new Assalariado();


            emp1.setNome("Nelson");
            emp1.setSobrenome("Hadi");
            emp1.setCpf("123.456.789/00");
            emp4.setPrecoHora(25f);
            emp4.setSHorasTrabalhadas(8f);
            emp6.setTotalVenda(72f);
            emp6.setTaxaComissao(15);
            emp8.setSalario(1000f);
            
            
            
            
            Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp4.ToString());
            Console.WriteLine(emp6.ToString());
            Console.WriteLine(emp8.ToString());
           
            Console.WriteLine(emp4.vencimento());
             Console.WriteLine(emp6.vencimento());
             Console.WriteLine(emp8.vencimento());
            
            
            
            
            Console.ReadKey();







        }
    }
}
