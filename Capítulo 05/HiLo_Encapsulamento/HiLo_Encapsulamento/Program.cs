namespace HiLo_Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem-vindo a HiLo.");
            Console.WriteLine($"Adivinhe números entre 1 e {JogoHiLo.MAXIMO}.");

            JogoHiLo.Dica();


            while (JogoHiLo.GetPote() > 0)
            {

                Console.WriteLine("\nPressione a para mais alto, b para mais baixo, ? para comprar uma dica,");
                Console.WriteLine($"ou qualquer outra tecla para sair com {JogoHiLo.GetPote()}.");
                char opcao = Console.ReadKey(true).KeyChar;


                if (opcao == 'a') JogoHiLo.Adivinhar(true);
                else if (opcao == 'b') JogoHiLo.Adivinhar(false);
                else if (opcao == '?') JogoHiLo.Dica();
                else return;

            }

            Console.WriteLine("O pote está vazio. Tchau!");

        }
    }
}
