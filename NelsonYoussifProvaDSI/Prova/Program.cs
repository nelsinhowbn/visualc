using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {

            Fusca v1 = new Fusca();
            Picapes10 v2 = new Picapes10();
            Cb200 v3 = new Cb200();
            Caiaque v4 = new Caiaque();
            Esquilo v5 = new Esquilo();
            Legacy450 v6 = new Legacy450();


        

            v1.setAno(1966);
            v1.setCorCarro("Branco");
            v1.setMarca("Fusca");
            v1.setPneu(4);
            
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v1.locomover());
            Console.WriteLine(v1.abastecer());

            Console.WriteLine("\n");
            v2.setAno(2001);
            v2.setCorCarro("Dourado");
            v2.setMarca("S10");
            v2.setPneu(4);
            Console.WriteLine(v2.ToString());
            Console.WriteLine(v2.locomover());
            Console.WriteLine(v2.abastecer());

            Console.WriteLine("\n");
            v3.setAno(2001);
            v3.setMarca("Moto CB200 - HONDA");
            v3.setCorMotocicleta("Preta");
            Console.WriteLine(v3.ToString());
            Console.WriteLine(v3.locomover());
            Console.WriteLine(v3.abastecer());

            Console.WriteLine("\n");
            v4.setMarca("Caiaque");
            v4.setAno(2011);
            v4.setCorCasco("Azul");
            Console.WriteLine(v4.ToString());
            Console.WriteLine(v4.locomover());
            Console.WriteLine(v4.abastecer());
            Console.WriteLine(v4.ancorar());
            
            
            
            
            Console.WriteLine("\n");
            v5.setMarca("Esquilo");
            v5.setAno(1994);
            v5.setCorFuselagem("Rosa");
            Console.WriteLine(v5.ToString());
            Console.WriteLine(v5.locomover());
            Console.WriteLine(v5.abastecer());
            Console.WriteLine(v5.arremeter());

            Console.WriteLine("\n");
            v6.setMarca("LEGACY 450");
            v6.setAno(2015);
            v6.setCorFuselagem("Preto e Branco");
            
            Console.WriteLine(v6.ToString());
            Console.WriteLine(v6.locomover());
            Console.WriteLine(v6.abastecer());
            Console.WriteLine(v6.arremeter());
            Console.WriteLine(v6.decolar("sol"));
            
            
            
            
            
            Console.ReadKey();



















        }
    }
}
