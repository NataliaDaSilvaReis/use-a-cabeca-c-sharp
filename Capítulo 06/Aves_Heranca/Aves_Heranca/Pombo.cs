using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aves_Heranca
{
    internal class Pombo : Ave
    {
        public override Ovo[] BotarOvos(int numeroDeOvos)
        {
            double tamanho;
            string cor = "branco";

            Ovo[] ovos = new Ovo[numeroDeOvos];


            for (int i = 0; i < numeroDeOvos; i++)
            {
                tamanho = random.NextDouble() * 2 + 1;

                if (Ave.random.Next(4) == 0)
                    ovos[i] = new OvoQuebrado("branco");
                else
                    ovos[i] = new Ovo(tamanho, cor);
            }

            return ovos;
        }
    }
}
