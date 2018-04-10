using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
    class Motocicleta : Veiculo
    {
        private String corMotocicleta;

        public string getCorMotocicleta()
        {
            return corMotocicleta;
        }

        public void setCorMotocicleta(string corMotocicleta)
        {
            this.corMotocicleta = corMotocicleta;
        }
        
        
        public override string locomover()
        {
            return "A Moto está se locomovendo...";
        }
        public override string abastecer()
        {
           return "A Moto está sendo abastecido...";
        }



        public string ToString()
        {
            return "Motocicleta {A Marca da Moto: " + marca + "\nCor da Moto: " + corMotocicleta + '}';
        }







    }
}
