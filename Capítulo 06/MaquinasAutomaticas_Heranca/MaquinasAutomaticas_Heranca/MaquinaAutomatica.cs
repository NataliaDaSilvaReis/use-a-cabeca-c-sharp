using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinasAutomaticas_Heranca
{
    internal class MaquinaAutomatica
    {

        protected virtual bool VerificarQuantia(decimal dinheiro)
        {
            return false;
        }

        public string Dispensar(decimal dinheiro)
        {
            if (VerificarQuantia(dinheiro)) return Item;
            else return "Por favor, insira o valor correto.";
        }


        // Início getters e setters.
        public virtual string Item { get; }
        // Fim getters e setters.
    }
}
