using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aves_Heranca
{
    internal class Avestruz : Ave
    {
        public override Ovo[] BotarOvos(int numeroDeOvos)
        {
            double tamanho;
            string cor = "salpicado";

            Ovo[] ovos = new Ovo[numeroDeOvos];


            for (int i = 0; i < numeroDeOvos; i++)
            {
                tamanho = random.NextDouble() + 12;
                ovos[i] = new Ovo(tamanho, cor);
            }

            return ovos;
        }
    }
}
