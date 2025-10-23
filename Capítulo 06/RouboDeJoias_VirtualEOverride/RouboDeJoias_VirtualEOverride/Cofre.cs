using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouboDeJoias_VirtualEOverride
{
    internal class Cofre
    {

        private string conteudo = "joias preciosas";
        private string combinacaoDoCofre = "12345";

        public string Abrir(string combinacao)
        {
            if (combinacao == combinacaoDoCofre) return conteudo;
            return "";
        }

        public void ArrombarFechadura(Chaveiro chaveiro)
        {
            chaveiro.Combinacao = combinacaoDoCofre;
        }
    }
}
