using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLo_Encapsulamento
{
    internal static class JogoHiLo
    {

        public const int MAXIMO = 10;
        private static Random random = new Random();
        private static int numeroAtual = random.Next(1, MAXIMO + 1);
        private static int pote = 10;



        public static void Adivinhar(bool maior)
        {

            int proximoNumero = random.Next(1, MAXIMO + 1);


            if (proximoNumero >= numeroAtual && maior || proximoNumero <= numeroAtual && !maior)
            {

                Console.WriteLine("Acertou!");
                pote++;

            }
            else
            {

                Console.WriteLine("Que azar, errou.");
                pote--;

            }


            numeroAtual = proximoNumero;
            Console.WriteLine($"O número atual é {numeroAtual}");

        }



        public static void Dica()
        {

            int metade = MAXIMO / 2;


            if (numeroAtual >= metade)
            {

                Console.WriteLine($"O número é no mínimo {metade}.");

            }
            else
            {

                Console.WriteLine($"O número é no máximo {metade}.");

            }

            pote--;

        }


        public static int GetPote()
        {
            return pote;
        }
    }
}
