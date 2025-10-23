using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouboDeJoias_VirtualEOverride
{
    internal class Chaveiro
    {

        public void AbrirCofre(Cofre cofre, DonoDoCofre dono)
        {
            cofre.ArrombarFechadura(this);

            string conteudoDoCofre = cofre.Abrir(Combinacao);
            DevolverConteudo(conteudoDoCofre, dono);
        }

        protected virtual void DevolverConteudo(string conteudoDoCofre, DonoDoCofre dono)
        {
            dono.ReceberConteudo(conteudoDoCofre);
        }


        // Início getters e setters.
        public string Combinacao { private get; set; }
        // Fim getters e setters.
    }
}
