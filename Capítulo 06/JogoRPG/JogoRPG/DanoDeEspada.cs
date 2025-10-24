using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    internal class DanoDeEspada : DanoDeArma
    {

        private const int DANO_BASE = 3;
        private const int DANOS_POR_CHAMA = 2;



        public DanoDeEspada(int rolarInicial) : base(rolarInicial) { }



        /// <summary>
        /// Calcula o dano com base nas propriedades atuais.
        /// </summary>
        protected override void CalcularDano()
        {
            decimal MultiplicadorMagico = 1M;
            if (Magico) MultiplicadorMagico = 1.75M;

            Dano = DANO_BASE;
            Dano = (int)(Rolar * MultiplicadorMagico) + DANO_BASE;

            if (Flamejante) Dano += DANOS_POR_CHAMA;

        }
    }
}
