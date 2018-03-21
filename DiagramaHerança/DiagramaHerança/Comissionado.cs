using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaHerança
{
   public class Comissionado : Empregado
    {
        private double totalVenda;
        private double taxaComissao;

        public double getTotalVenda()
        {
            return totalVenda;
        }

        public void setTotalVenda(double totalVenda)
        {
            this.totalVenda = totalVenda;
        }

        public double getTaxaComissao()
        {
            return taxaComissao;
        }
        public void setTaxaComissao(double taxaComissao)
        {
            this.taxaComissao = taxaComissao;
        }

        public override double vencimento()
        {
            return taxaComissao+totalVenda;
        }
        public override string ToString()
        {
            return "\n Comissionado{" + " Total da Venda= " + totalVenda + ", Taxa da Comissão= " + taxaComissao + '}'; 
        }







    }
}
