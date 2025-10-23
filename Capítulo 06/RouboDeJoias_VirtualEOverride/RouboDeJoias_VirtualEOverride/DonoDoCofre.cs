using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouboDeJoias_VirtualEOverride
{
    internal class DonoDoCofre
    {

        private string objetosDeValor = "";


        public void ReceberConteudo(string conteudoDoCofre)
        {
            objetosDeValor = conteudoDoCofre;
            Console.WriteLine($"Obrigado por devolver minhas {objetosDeValor}!");
        }
    }
}
