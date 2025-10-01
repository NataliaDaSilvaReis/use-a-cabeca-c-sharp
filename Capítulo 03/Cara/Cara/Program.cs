namespace Cara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cara joe = new Cara() { _dinheiro = 50, _nome = "Joe" };
            Cara bob = new Cara() { _dinheiro = 100, _nome = "Bob" };


            while (true)
            {
                joe.EscrevaMinhasInformacoes();
                bob.EscrevaMinhasInformacoes();

                Console.Write("\nInsira um valor: ");
                string quanto = Console.ReadLine();
                if (quanto == "") return;

                if (double.TryParse(quanto, out double quantia))
                {
                    Console.Write("Quem deve dar o dinheiro: ");
                    string qualCara = Console.ReadLine();
                    Console.WriteLine();

                    if (qualCara == "Joe")
                    {
                        double dinheiroDado = joe.DarDinheiro(quantia);
                        bob.ReceberDinheiro(dinheiroDado);
                    }
                    else if (qualCara == "Bob")
                    {
                        double dinheiroDado = bob.DarDinheiro(quantia);
                        joe.ReceberDinheiro(dinheiroDado);
                    }
                    else
                    {
                        Console.WriteLine("Por favor, digite 'Joe' ou 'Bob'.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira um valor (ou uma linha em branco para sair).");
                }
            }
        }
    }
}
