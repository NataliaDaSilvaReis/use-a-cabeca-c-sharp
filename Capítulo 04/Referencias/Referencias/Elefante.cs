using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referencias
{
    internal class Elefante
    {

        public string _nome;
        public int _tamanhoOrelha;

        public void QuemSouEu()
        {

            Console.WriteLine($"Meu nome é {_nome}.");
            Console.WriteLine($"Minhas orelhas têm {_tamanhoOrelha} centímetros de altura.");

        }


        public void OuvirMensagem(string mensagem, Elefante quemDisseIsso)
        {

            Console.WriteLine($"{_nome} ouviu a mensagem");
            Console.WriteLine($"{quemDisseIsso._nome} disse isso: {mensagem}");

        }


        public void FalarCom(Elefante comQuemFalar, string mensagem)
        {

            comQuemFalar.OuvirMensagem(mensagem, this);

        }

    }
}
