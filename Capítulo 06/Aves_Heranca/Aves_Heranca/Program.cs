namespace Aves_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Ave ave;


                Console.Write("\nPressione P para pombo, A para avestruz: ");
                char opcao = Char.ToUpper(Console.ReadKey().KeyChar);

                if (opcao == 'P') ave = new Pombo();
                else if (opcao == 'A') ave = new Avestruz();
                else return;

                Console.Write("\nQuantos ovos deve botar? ");
                if (!int.TryParse(Console.ReadLine(), out int numeroDeOvos)) return;
                Ovo[] ovos = ave.BotarOvos(numeroDeOvos);

                foreach (Ovo ovo in ovos)
                {
                    Console.WriteLine(ovo.Descricao);
                }
            }
        }
    }
}
