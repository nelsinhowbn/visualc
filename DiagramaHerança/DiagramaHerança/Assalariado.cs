using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaHerança
{
   public  class Assalariado : Empregado
    {
        private double salario;
       
        
        
        
        public double getSalario()
        {
            return salario;
        }

        public void setSalario (double salario)
        {
            this.salario = salario;
        }




        public override double vencimento()
        {
            return salario;
        }
        public override string ToString()
        {
            return "\n Assalariado{" + "Salario= " +salario+ '}'; 
        }











    }
}
