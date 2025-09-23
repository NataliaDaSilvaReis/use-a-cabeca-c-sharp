using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolhaUmaCartaIU
{
    internal class SelecionadorDeCartas
    {
        /// <summary>
        /// Argumento utilizado para os sorteios de valores.
        /// </summary>
        static Random random = new Random();

        /// <summary>
        /// Retorna cartas aleatórias a partir de uma quantidade.
        /// </summary>
        /// <param name="numeroDeCartas">O número de cartas a serem escolhidas.</param>
        /// <returns>Um array de strings com o nome das cartas.</returns>
        public static string[] EscolhaAlgumasCartas(int numeroDeCartas)
        {
            string[] cartasEscolhidas = new string[numeroDeCartas];

            for (int i = 0; i < numeroDeCartas; i++)
            {
                cartasEscolhidas[i] = ValorAleatorio() + " de " + NaipeAleatorio();
            }

            return cartasEscolhidas;
        }

        /// <summary>
        /// A partir de um número aletório, é selecionado o naipe da carta.
        /// </summary>
        /// <returns>Uma string com o nome do naipe sorteado.</returns>
        private static string NaipeAleatorio()
        {
            // Obter um número aleatório de 1 a 4
            int valor = random.Next(1, 5);

            // Se for 1, retornar a string Espadas
            if (valor == 1) return "Espadas";

            // Se for 2, retornar a string Copas
            if (valor == 2) return "Copas";

            // Se for 3, retornar a string Paus
            if (valor == 3) return "Paus";

            // Se ainda não foi retornado, retornar a string Ouros
            return "Ouros";
        }

        /// <summary>
        /// A partir de um número aleatório (entre 1 e 13), retorna o número da carta.
        /// </summary>
        /// <returns>Uma string com o número da carta que foi sorteado.</returns>
        private static string ValorAleatorio()
        {
            // Sorteia um número aleatório entre 1 e 13 e retorna de acordo com o nome da carta do baralho
            int valor = random.Next(1, 14);

            if (valor == 1) return "Ás";
            if (valor == 11) return "Valete";
            if (valor == 12) return "Dama";
            if (valor == 13) return "Rei";
            return valor.ToString();
        }
    }
}
