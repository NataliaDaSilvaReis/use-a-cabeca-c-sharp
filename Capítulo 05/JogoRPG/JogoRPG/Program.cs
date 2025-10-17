namespace JogoRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanoDeEspada danoDeEspada = new DanoDeEspada();
            Random random = new Random();

            while (true)
            {
                Console.Write("0 para nenhuma magia/chama, 1 para magia, 2 para chama, 3 para ambos, qualquer outra coisa para sair: ");
                char opcao = Console.ReadKey(false).KeyChar;

                // Retorna caso a pessoa não digite 0, 1, 2 ou 3.
                if (opcao != '0' && opcao != '1' && opcao != '2' && opcao != '3') return;


                // Rolar 3d6.
                int valorDados = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                danoDeEspada.Rolar = valorDados;


                // Caso o usuário possuir magia.
                danoDeEspada.DefinirMagia(opcao == '1' || opcao == '3');

                // Caso o usuário possuir poder de chama.
                danoDeEspada.DefinirFlamejante(opcao == '2' || opcao == '3');


                Console.WriteLine($"\nRolou {valorDados} por {danoDeEspada.Dano} HP\n");

            }
        }
    }
}
