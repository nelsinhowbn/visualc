using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaHerança
{
     public class Horista : Empregado
    {
        private double precoHora;
        private double horasTrabalhadas;

        public double getPrecoHora()
        {
            return precoHora;
        }

        public void setPrecoHora(double precoHora)
        {
            this.precoHora = precoHora;
        }

        public double getHorasTrabalhadas()
        {
            return horasTrabalhadas;
        }
        public void setSHorasTrabalhadas(double horasTrabalhadas)
        {
            this.horasTrabalhadas = horasTrabalhadas;
        }


        public override double vencimento()
        {

            return horasTrabalhadas*precoHora;
        }

        public override string ToString()
        {
            return "\n Horista{" + "Preço da Hora= " + precoHora + ", Horas Trabalhadas= " +horasTrabalhadas+'}'; ;
        }




    }
}
