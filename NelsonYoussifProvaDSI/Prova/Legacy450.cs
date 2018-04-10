using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{          




    class Legacy450 : Aeronave
    { 
        public override string locomover()
        {
            return "Levacy se locomovendo por Turbina";
        }

        public override string abastecer()
        {
            return "Legacy sendo abastecido por Turbina";
        }

     
 
        public string decolar(string clima)
        {
            if (clima == "sol")
            {
                return "Voo sera normal";
            }

            if (clima == "chuva" && clima == "nublado")
            {
                return "Voo sera por  instrumento";
            }

            else
            {
                return "não Vai ter voo";
            }
        }

        public int decolar(int horario)
        {
            if (horario >= 1 && horario <= 12)
            {
                Console.WriteLine(" Altitude mais alta");
            }

            if (horario > 12 && horario <= 18)
            {
                Console.WriteLine("A altitude média");
            }

            else
            {
                Console.WriteLine("Altitude baixa");
            }
            return horario;
        }

        public Boolean decolar(Boolean passageiro)
        {
            if (passageiro == true)
            {
                Console.WriteLine("Servir refeição");
            }

            else
            {
                Console.WriteLine("Amarrar bem a carga");
            }
            return passageiro;
        }


        }
    }

