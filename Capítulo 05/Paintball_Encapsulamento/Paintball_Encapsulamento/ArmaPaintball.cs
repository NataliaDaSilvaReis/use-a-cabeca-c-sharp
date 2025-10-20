using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paintball_Encapsulamento
{
    internal class ArmaPaintball
    {

        private int bolas = 0;



        // Método Construtor
        public ArmaPaintball(int bolas, int tamanhoDoCarregador, bool carregada)
        {

            this.bolas = bolas;
            TamanhoDoCarregador = tamanhoDoCarregador;
            if (!carregada) Recarregar();

        }

        // Início dos métodos Getters e Setters.
        public int TamanhoDoCarregador { get; private set; }

        public int BolasCarregadas { get; private set; }

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
            return BolasCarregadas == 0;
        }

        public void Recarregar()
        {

            if (bolas > TamanhoDoCarregador)
            {

                BolasCarregadas = TamanhoDoCarregador;

            }
            else
            {

                BolasCarregadas = bolas;

            }
        }

        public bool Atirar()
        {

            if (BolasCarregadas == 0) return false;

            BolasCarregadas--;
            bolas--;

            return true;

        }
    }
}
