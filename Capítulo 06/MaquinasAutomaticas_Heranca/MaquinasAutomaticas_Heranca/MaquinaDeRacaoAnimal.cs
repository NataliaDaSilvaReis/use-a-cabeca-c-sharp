using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinasAutomaticas_Heranca
{
    internal class MaquinaDeRacaoAnimal : MaquinaAutomatica
    {

        protected override bool VerificarQuantia(decimal dinheiro)
        {
            return dinheiro >= 1.25M;
        }


        // Início getters e setters.
        public override string Item
        {
            get { return "Um punhado de ração animal."; }
        }
        // Fim getters e setters.
    }
}
