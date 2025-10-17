using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    internal class DanoDeEspada
    {

        public const int DANO_BASE = 3;
        public const int DANOS_POR_CHAMA = 2;

        public int Rolar;
        public decimal MultiplicadorMagico = 1M;
        public int DanoFlamejante = 0;
        public int Dano;



        public void CalcularDano()
        {
            Dano = (int)(Rolar * MultiplicadorMagico) + DANO_BASE + DanoFlamejante;
        }


        public void DefinirMagia(bool ehMagico)
        {
            if (ehMagico)
            {
                MultiplicadorMagico = 1.75M;
            }
            else
            {
                MultiplicadorMagico = 1M;
            }

            CalcularDano();
        }


        public void DefinirFlamejante(bool ehFlamejante)
        {
            CalcularDano();

            if (ehFlamejante)
            {
                Dano += DANOS_POR_CHAMA;
            }
        }
    }
}
