namespace Paintball_Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numeroDeBolas = LeiaInt(20, "Número de bolas");
            int tamanhoDoCarregador = LeiaInt(16, "Tamanho do carregagor");

            Console.Write($"Carregada [false]: ");
            bool.TryParse(Console.ReadLine(), out bool estaCarregada);
            Console.WriteLine();

            ArmaPaintball arma = new ArmaPaintball(numeroDeBolas, tamanhoDoCarregador, estaCarregada);



            while (true)
            {

                Console.WriteLine($"{arma.Bolas} bolas, {arma.BolasCarregadas} carregadas");

                if (arma.SemMunicao()) Console.WriteLine("AVISO: você está sem munição");

                Console.WriteLine("Barra de espaço para atirar, r para recarregar, + para adicionar munição, s para sair\n");
                char opcao = Console.ReadKey(true).KeyChar;

                if (opcao == ' ') Console.WriteLine($"Atirar retornou {arma.Atirar()}");
                else if (opcao == 'r') arma.Recarregar();
                else if (opcao == '+') arma.Bolas += arma.TamanhoDoCarregador;
                else if (opcao == 's') return;

            }

            static int LeiaInt(int ultimoValorUsado, string prompt)
            {

                Console.Write($"{prompt} [{ultimoValorUsado}]: ");
                string linha = Console.ReadLine();

                if (int.TryParse(linha, out int valor))
                {

                    Console.WriteLine("    usando valor " + valor);
                    return valor;

                }
                else
                {

                    Console.WriteLine("    usando o valor padrão " + ultimoValorUsado);
                    return ultimoValorUsado;

                }
            }
        }
    }
}
