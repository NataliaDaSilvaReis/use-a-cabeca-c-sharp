namespace Paintball_Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArmaPaintball arma = new ArmaPaintball();



            while (true)
            {

                Console.WriteLine($"{arma.GetBolas()} bolas, {arma.GetBolasCarregadas()} carregadas");

                if (arma.SemMunicao()) Console.WriteLine("AVISO: você está sem munição");

                Console.WriteLine("Barra de espaço para atirar, r para recarregar, + para adicionar munição, s para sair\n");
                char opcao = Console.ReadKey(true).KeyChar;

                if (opcao == ' ') Console.WriteLine($"Atirar retornou {arma.Atirar()}");
                else if (opcao == 'r') arma.Recarregar();
                else if (opcao == '+') arma.SetBolas(arma.GetBolas() + ArmaPaintball.TAMANHO_DO_CARREGADOR);
                else if (opcao == 's') return;

            }
        }
    }
}
