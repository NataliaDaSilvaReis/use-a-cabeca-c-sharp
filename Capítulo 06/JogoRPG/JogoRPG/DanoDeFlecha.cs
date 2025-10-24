using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    internal class DanoDeFlecha : DanoDeArma
    {
        private const decimal MULTIPLICADOR_BASE = 0.35M;
        private const decimal MULTIPLICADOR_MAGICO = 2.5M;
        private const decimal DANOS_POR_CHAMA = 1.25M;



        public DanoDeFlecha(int rolarInicial) : base(rolarInicial) { }



        /// <summary>
        /// Calcula o dano com base nas propriedades atuais.
        /// </summary>
        protected override void CalcularDano()
        {
            decimal danoBase = Rolar * MULTIPLICADOR_BASE;

            if (Magico) danoBase *= MULTIPLICADOR_MAGICO;
            if (Flamejante) Dano = (int)Math.Ceiling(danoBase + DANOS_POR_CHAMA);
            else Dano = (int)Math.Ceiling(danoBase);

        }
    }
}
