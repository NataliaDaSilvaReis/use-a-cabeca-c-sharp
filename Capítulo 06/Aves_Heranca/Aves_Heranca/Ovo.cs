using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aves_Heranca
{
    internal class Ovo
    {
        public Ovo(double tamanho, string cor)
        {
            Tamanho = tamanho;
            Cor = cor;
        }


        // Início getters e setters.
        public string Descricao
        {
            get { return $"Um ovo {Cor} de {Tamanho:0.0} cm"; }
        }

        public double Tamanho { get; private set; }

        public string Cor { get; private set; }
        // Fim getters e setters.

    }
}
