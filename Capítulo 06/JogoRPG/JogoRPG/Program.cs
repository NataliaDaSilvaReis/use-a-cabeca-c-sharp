namespace JogoRPG
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {

            DanoDeEspada danoDeEspada = new DanoDeEspada(RolarDado(3));
            DanoDaFlecha danoDeFlecha = new DanoDaFlecha(RolarDado(1));

            while (true)
            {
                Console.Write("0 para nenhuma magia/chama, 1 para magia, 2 para chama, 3 para ambos, qualquer outra tecla para sair: ");
                char opcao = Console.ReadKey(false).KeyChar;

                // Retorna caso a pessoa não digite 0, 1, 2 ou 3.
                if (opcao != '0' && opcao != '1' && opcao != '2' && opcao != '3') return;

                Console.Write("\nE para espada, F para flecha, qualquer outra tecla para sair: ");
                char opcaoArma = Char.ToUpper(Console.ReadKey().KeyChar);


                switch (opcaoArma)
                {
                    case 'E':
                        danoDeEspada.Rolar = RolarDado(3);

                        // Caso o usuário possuir magia.
                        danoDeEspada.Magico = (opcao == '1' || opcao == '3');

                        // Caso o usuário possuir poder de chama.
                        danoDeEspada.Flamejante = (opcao == '2' || opcao == '3');


                        Console.WriteLine($"\nRolou {danoDeEspada.Rolar} por {danoDeEspada.Dano} HP\n");
                        break;

                    case 'F':
                        danoDeFlecha.Rolar = RolarDado(1);

                        danoDeFlecha.Magico = (opcao == '1' || opcao == '3');
                        danoDeFlecha.Flamejante = (opcao == '2' || opcao == '3');


                        Console.WriteLine($"\nRolou {danoDeFlecha.Rolar} por {danoDeFlecha.Dano} HP\n");
                        break;

                    default:
                        return;

                }
            }
        }

        private static int RolarDado(int numeroDeLancamentos)
        {

            int total = 0;

            for (int i = 0; i < numeroDeLancamentos; i++)
            {
                total += random.Next(1, 7);
            }

            return total;
        }
    }
}