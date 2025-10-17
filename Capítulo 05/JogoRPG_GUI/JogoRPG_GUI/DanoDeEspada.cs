using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace JogoRPG_GUI
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
            Debug.WriteLine($"CalcularDano finalizado: {Dano} (rolar: {Rolar})");
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
            Debug.WriteLine($"DefinirMagia finalizado: {Dano} (rolar: {Rolar})");
        }


        public void DefinirFlamejante(bool ehFlamejante)
        {
            CalcularDano();

            if (ehFlamejante)
            {
                Dano += DANOS_POR_CHAMA;
            }
            Debug.WriteLine($"DefinirFlamejante finalizado: {Dano} (rolar: {Rolar})");
        }
    }
}
