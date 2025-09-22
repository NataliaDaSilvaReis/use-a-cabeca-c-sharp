namespace EscolhaCartasAleatórias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de cartas a serem escolhidas: ");
            string linha = Console.ReadLine();

            if (int.TryParse(linha, out int numeroDeCartas))
            {
                foreach(string carta in SelecionadorDeCartas.EscolhaAlgumasCartas(numeroDeCartas))
                {
                    Console.WriteLine(carta);
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }
    }
}
