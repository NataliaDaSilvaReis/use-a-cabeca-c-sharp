using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paintball_Encapsulamento
{
    internal class ArmaPaintball
    {

        public const int TAMANHO_DO_CARREGADOR = 16;

        private int bolas = 0;
        private int bolasCarregadas = 0;



        // Início dos métodos Getters e Setters.
        public int GetBolasCarregadas()
        {
            return bolasCarregadas;
        }

        public int Bolas
        {
            get { return bolas; }

            set
            {
                if (value > 0)
                {
                    bolas = value;
                }

                Recarregar();
            }
        }
        // Fim dos métodos Getters e Setters.



        public bool SemMunicao()
        {
            return bolasCarregadas == 0;
        }

        public void Recarregar()
        {

            if (bolas > TAMANHO_DO_CARREGADOR)
            {

                bolasCarregadas = TAMANHO_DO_CARREGADOR;

            }
            else
            {

                bolasCarregadas = bolas;

            }
        }

        public bool Atirar()
        {

            if (bolasCarregadas == 0) return false;

            bolasCarregadas--;
            bolas--;

            return true;

        }
    }
}
