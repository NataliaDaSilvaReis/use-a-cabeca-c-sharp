using System;

namespace JogoRPG
{
    internal class Program
    {

        static Random random = new Random();

        static void Main(string[] args)
        {

            DanoDeEspada danoDeEspada = new DanoDeEspada(RolarDado());

            while (true)
            {
                Console.Write("0 para nenhuma magia/chama, 1 para magia, 2 para chama, 3 para ambos, qualquer outra coisa para sair: ");
                char opcao = Console.ReadKey(false).KeyChar;

                // Retorna caso a pessoa não digite 0, 1, 2 ou 3.
                if (opcao != '0' && opcao != '1' && opcao != '2' && opcao != '3') return;


                danoDeEspada.Rolar = RolarDado();

                // Caso o usuário possuir magia.
                danoDeEspada.Magico = (opcao == '1' || opcao == '3');

                // Caso o usuário possuir poder de chama.
                danoDeEspada.Flamejante = (opcao == '2' || opcao == '3');


                Console.WriteLine($"\nRolou {danoDeEspada.Rolar} por {danoDeEspada.Dano} HP\n");

            }
        }

        private static int RolarDado()
        {
            return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        }
    }
}
