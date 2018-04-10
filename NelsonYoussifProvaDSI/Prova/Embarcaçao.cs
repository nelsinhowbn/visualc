using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
    class Embarcaçao : Veiculo
    {
        private String corCasco;

        public string getCorCasco()
        {
            return corCasco;
        }

        public void setCorCasco(string corCasco)
        {
            this.corCasco = corCasco;
        }

        public override string locomover()
        {
            return "A Embarcação está se locomovendo...";
        }
        public override string abastecer()
        {
            return "A Embarcação  está sendo abastecido...";
        }
        public string ancorar()
        {
            return " A Embarcação está sendo ancorada...";
        }

        public override string ToString()
        {
            return "Embarcação{" + "\n marca = " + marca + "\n ano  = " + ano + "\n Cor do Casco = " + corCasco +'}';

        }
















    }
}
