using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aves_Heranca
{
    internal class OvoQuebrado : Ovo
    {

        public OvoQuebrado(string cor) : base(0, $"{cor} quebrado")
        {
            Console.WriteLine("Um pássaro botou um ovo quebrado.");
        }
    }
}
