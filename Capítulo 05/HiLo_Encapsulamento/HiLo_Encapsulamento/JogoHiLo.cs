using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLo_Encapsulamento
{
    /// <summary>
    /// Classe responsável por controlar a lógica do jogo Hi-Lo.
    /// No jogo, o jogador deve adivinhar se o próximo número gerado será
    /// maior ou menor que o número atual.
    /// </summary>
    internal static class JogoHiLo
    {

        /// <summary>
        /// Valor máximo que pode ser sorteado no jogo.
        /// </summary>
        public const int MAXIMO = 10;

        /// <summary>
        /// Gerador de números aleatórios utilizado no jogo.
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// Número atual mostrado ao jogador.
        /// </summary>
        private static int numeroAtual = random.Next(1, MAXIMO + 1);

        /// <summary>
        /// Próximo número que será revelado após a jogada.
        /// </summary>
        private static int proximoNumero = random.Next(1, MAXIMO + 1);

        /// <summary>
        /// Representa o pote de pontos do jogador.
        /// Aumenta ao acertar e diminui ao errar ou pedir dicas.
        /// </summary>
        private static int pote = 10;



        /// <summary>
        /// Verifica se a aposta do jogador (maior ou menor) está correta.
        /// Se o jogador acertar, ganha 1 ponto; se errar, perde 1 ponto.
        /// O número atual é atualizado para o próximo número, e um novo número é sorteado.
        /// </summary>
        /// <param name="maior">
        /// True se o jogador apostar que o próximo número será maior ou igual ao atual;
        /// False se apostar que será menor ou igual.
        /// </param>
        public static void Adivinhar(bool maior)
        {

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
            proximoNumero = random.Next(1, MAXIMO + 1);
            Console.WriteLine($"O número atual é {numeroAtual}");

        }



        /// <summary>
        /// Fornece uma dica ao jogador sobre o próximo número.
        /// Informa se ele será no mínimo ou no máximo a metade do valor máximo.
        /// Cada dica custa 1 ponto no pote.
        /// </summary>
        public static void Dica()
        {

            int metade = MAXIMO / 2;


            if (proximoNumero >= metade)
            {

                Console.WriteLine($"O número atual é {numeroAtual}, o próximo número é no mínimo {metade}.");

            }
            else
            {

                Console.WriteLine($"O número atual é {numeroAtual}, o próximo número é no máximo {metade}.");

            }

            pote--;

        }



        public static int GetPote()
        {
            return pote;
        }
    }
}
