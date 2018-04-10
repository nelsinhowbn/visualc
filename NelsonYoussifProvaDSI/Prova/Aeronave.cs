using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
    class Aeronave : Veiculo
    {
        private String corFuselagem;
        

        public string getCorFuselagem()
        {
            return corFuselagem;
        }

        public void setCorFuselagem(string corFuselagem)
        {
            this.corFuselagem = corFuselagem;
        }

        public override string locomover()
        {
            return "A Aeronave está se locomovendo...";
        }
        public override string abastecer()
        {
            return "A Aeronave  está sendo abastecido...";
        }
        public string arremeter()
        {
            return "A Aeronave está sendo arremetida...";
        }

       

        public override string ToString()
        {
            return "Aeronave{" + "\n marca = " + marca + "\n ano  = " + ano + "\n Cor da Fuselagem = " + corFuselagem + '}';

        }


















    }
}
