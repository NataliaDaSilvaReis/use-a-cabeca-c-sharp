namespace Apostas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const double _chances = 0.75;
            Cara jogador = new Cara() { _dinheiro = 100, _nome = "O jogador" };


            Console.WriteLine($"Bem-vindo ao cassino. As probabilidades são de {_chances}.");
            Console.WriteLine();

            while (jogador._dinheiro > 0)
            {
                jogador.EscrevaMinhasInformacoes();
                Console.Write("Quanto você quer apostar: ");
                string quanto = Console.ReadLine();

                if (double.TryParse(quanto, out double quantia))
                {
                    double pote = jogador.DarDinheiro(quantia) * 2;

                    if (pote > 0)
                    {
                        if (random.NextDouble() > _chances)
                        {
                            jogador.ReceberDinheiro(pote);
                            Console.WriteLine($"Você ganhou {pote}.");
                        }
                        else
                        {
                            Console.WriteLine("Má sorte, você perdeu.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }
            }

            Console.WriteLine("A casa sempre ganha.");
        }
    }
}
