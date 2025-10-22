using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    internal class DanoDeEspada
    {

        private const int DANO_BASE = 3;
        private const int DANOS_POR_CHAMA = 2;

        private int rolar;
        private bool flamejante;
        private bool magico;



        /// <summary>
        /// O construtor calcula o dano com base nos valores Magico
        /// e Flamejante padrão, em um dado 3d6 inicial.
        /// </summary>
        /// <param name="rolarInicial">Dado inicial 3d6.</param>
        public DanoDeEspada(int rolarInicial)
        {

            rolar = rolarInicial;
            CalcularDano();

        }



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
        public int Dano { get; private set; }

        // Fim getters e setters.



        /// <summary>
        /// Calcula o dano com base nas propriedades atuais.
        /// </summary>
        private void CalcularDano()
        {
            decimal MultiplicadorMagico = 1M;
            if (Magico) MultiplicadorMagico = 1.75M;

            Dano = DANO_BASE;
            Dano = (int)(Rolar * MultiplicadorMagico) + DANO_BASE;

            if (Flamejante) Dano += DANOS_POR_CHAMA;

        }
    }
}
