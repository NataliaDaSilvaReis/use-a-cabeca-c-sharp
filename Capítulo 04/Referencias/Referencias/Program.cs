namespace Referencias
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Elefante lucinda = new Elefante() { _nome = "Lucinda", _tamanhoOrelha = 84 };
            Elefante lloyd = new Elefante() { _nome = "Lloyd", _tamanhoOrelha = 102 };
            Elefante auxiliar;


            Console.WriteLine("Pressione 1 para Lloyd, 2 para Lucinda, 3 para trocar");

            while (true)
            {

                char linha = Console.ReadKey(true).KeyChar;

                if (int.TryParse(linha.ToString(), out int opcao))
                {
                    Console.WriteLine($"Você pressionou {opcao}");

                    if (opcao == 1)
                    {

                        Console.WriteLine("Chamando lloyd.QuemSouEu()");
                        lloyd.QuemSouEu();

                    }
                    else if (opcao == 2)
                    {

                        Console.WriteLine("Chamando lucinda.QuemSouEu()");
                        lucinda.QuemSouEu();

                    }
                    else if (opcao == 3)
                    {

                        auxiliar = lloyd;
                        lloyd = lucinda;
                        lucinda = auxiliar;

                        Console.WriteLine("As referências foram trocadas");

                    }
                    else if (opcao == 4)
                    {

                        lloyd = lucinda;
                        lloyd._tamanhoOrelha = 4321;
                        lloyd.QuemSouEu();

                    }
                    else if (opcao == 5)
                    {

                        lucinda.FalarCom(lloyd, "Olá, Lloyd!");

                    }
                    else
                    {
                        Console.WriteLine("Pressione uma opção válida.");
                    }

                }
                else
                {
                    Console.WriteLine("Pressione uma opção válida.");
                }

                Console.WriteLine();

            }

        }

    }
}
