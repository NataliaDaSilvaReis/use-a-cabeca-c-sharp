using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouboDeJoias_VirtualEOverride
{
    internal class LadraoDeJoias : Chaveiro
    {

        private string joiasRoubadas;

        protected override void DevolverConteudo(string conteudoDoCofre, DonoDoCofre dono)
        {
            joiasRoubadas = conteudoDoCofre;
            Console.WriteLine($"Estou roubando as joias! Eu roubei: {joiasRoubadas}");
        }
    }
}
