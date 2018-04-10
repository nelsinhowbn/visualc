using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
  class Carro : Veiculo
    {
       
        public string corCarro;

        public string getCorCarro()
        {
            return corCarro;
        }
        public void setCorCarro(string corCarro)
        {
            this.corCarro = corCarro;
        }

        public override string ToString()
        {
            return "Carro{" + "\n marca = " + marca + "\n ano  = " + ano + "\n pneu = " + pneu + '}';

        }



    }
}
