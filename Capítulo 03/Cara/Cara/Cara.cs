using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cara
{
    internal class Cara
    {
        public string _nome;
        public double _dinheiro;


        /// <summary>
        /// Escreve o nome e a quantia de dinheiro no console.
        /// </summary>
        public void EscrevaMinhasInformacoes()
        {
            Console.WriteLine($"{_nome} tem {_dinheiro} reais.");
        }


        /// <summary>
        /// Dá parte do dinheiro, retirando-o da carteira (ou escrevendo uma mensagem no console se não houver dinheiro suficiente).
        /// </summary>
        /// <param name="quantia">Quantia de dinheiro a entregar.</param>
        /// <returns>
        /// A quantia de dinheiro removida da carteira ou 0 se não houver dinheiro suficiente (ou se a quantia é inválida).
        /// </returns>
        public double DarDinheiro(double quantia)
        {
            if (quantia <= 0)
            {
                Console.WriteLine($"{_nome} diz: {quantia} não é um valor válido.");

                return 0;
            }

            if (quantia > _dinheiro)
            {
                Console.WriteLine($"{_nome} diz: Não tenho dinheiro suficiente para lhe dar {quantia}");

                return 0;
            }

            _dinheiro -= quantia;

            return quantia;
        }


        /// <summary>
        /// Recebe algum dinheiro, adicionando-o a carteira (ou escrevendo uma mensagem no console se a quantia é inválida).
        /// </summary>
        /// <param name="quantia">Quantia de dinheiro a entregar.</param>
        public void ReceberDinheiro(double quantia)
        {
            if (quantia <= 0)
            {
                Console.WriteLine($"{_nome} diz: {quantia} não é uma quantia que eu aceitaria.");
            }
            else
            {
                _dinheiro += quantia;
            }
        }
    }
}