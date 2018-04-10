using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
    class Veiculo
    {
       public String marca;
       public int ano;
       public int pneu;

       public virtual string locomover()
       {
           return "O Veiculo está se Locomovendo";
       }
       public virtual string abastecer()
       {
           return "Abastecendo com";
       }

       public String getMarca()
       {
           return marca;
       }
       public void setMarca(String marca)
       {
           this.marca = marca;
       }


       public int getAno()
       {
           return ano;
       }
       public void setAno(int ano)
       {
           this.ano = ano;
       }

       
       public int getPneu()
       {
           return pneu;
       }
       public void setPneu(int pneu)
       {
           this.pneu = pneu;
       }


      
















    }
}
