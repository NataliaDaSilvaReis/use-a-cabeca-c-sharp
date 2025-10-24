using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    internal class DanoDeArma
    {
        private int rolar;
        private bool flamejante;
        private bool magico;



        /// <summary>
        /// O construtor calcula o dano com base nos valores Magico
        /// e Flamejante padrão, em um dado 3d6 inicial.
        /// </summary>
        /// <param name="rolarInicial">Dado inicial 3d6.</param>
        public DanoDeArma(int rolarInicial)
        {

            rolar = rolarInicial;
            CalcularDano();

        }



        protected virtual void CalcularDano() { Console.WriteLine("Teste pra ver se chama"); }



        // Início getters e setters.

        /// <summary>
        /// Define com set ou obtém com get o dado 3d6.
        /// </summary>
        public int Rolar
        {
            get { return rolar; }
            set
            {
                rolar = value;
                CalcularDano();
            }
        }

        /// <summary>
        /// True se a espada está em chamas, false do contrário.
        /// </summary>
        public bool Flamejante
        {
            get { return flamejante; }
            set
            {
                flamejante = value;
                CalcularDano();
            }
        }

        /// <summary>
        /// True se a espada é mágica, false do contrário.
        /// </summary>
        public bool Magico
        {
            get { return magico; }
            set
            {
                magico = value;
                CalcularDano();
            }
        }

        /// <summary>
        /// Contém o dano calculado.
        /// </summary>
        public int Dano { get; protected set; }

        // Fim getters e setters.
    }
}
