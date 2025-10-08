using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestadorDePontuacaoDeHabilidade
{
    internal class CalculadoraDePontuacaoDeHabilidade
    {
        public int ResultadoDoLancamento = 14;
        public double DividirPor = 1.75;
        public int AddValor = 2;
        public int Minimo = 3;
        public int _pontuacao;

        public void CalcularPontuacaoDeHabilidade()
        {

            // Divida o resultado pelo campo DividirPor
            double dividido = ResultadoDoLancamento / DividirPor;

            // Arredonde para baixo o resultado da divisão e adicione AddValor
            int adicionado = AddValor + (int)dividido;

            // Se o resultado for muito pequeno, use o Minimo
            if (adicionado < Minimo)
            {
                _pontuacao = Minimo;
            }
            else
            {
                _pontuacao = adicionado;
            }

        }
    }
}
