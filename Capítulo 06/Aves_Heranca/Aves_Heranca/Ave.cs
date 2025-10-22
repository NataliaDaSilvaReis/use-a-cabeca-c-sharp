using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aves_Heranca
{
    internal class Ave
    {

        public static Random random = new Random();

        public virtual Ovo[] BotarOvos(int numeroDeOvos)
        {
            Console.Error.WriteLine("Ave.BotarOvos não deve ser chamado diretamente.");
            return new Ovo[0];
        }
    }
}
