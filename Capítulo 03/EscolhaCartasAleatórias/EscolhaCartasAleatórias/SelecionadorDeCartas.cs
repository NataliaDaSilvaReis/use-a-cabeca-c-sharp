using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolhaCartasAleatórias
{
    internal class SelecionadorDeCartas
    {
        static Random random = new Random();

        public static string[] EscolhaAlgumasCartas(int numeroDeCartas)
        {
            string[] cartasEscolhidas = new string[numeroDeCartas];

            for (int i = 0; i < numeroDeCartas; i++)
            {
                cartasEscolhidas[i] = ValorAleatorio() + " de " + NaipeAleatorio();
            }

            return cartasEscolhidas;
        }

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
