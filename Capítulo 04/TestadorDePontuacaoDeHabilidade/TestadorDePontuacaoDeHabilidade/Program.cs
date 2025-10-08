using System.Drawing;

namespace TestadorDePontuacaoDeHabilidade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CalculadoraDePontuacaoDeHabilidade calculadora = new CalculadoraDePontuacaoDeHabilidade();


            while (true)
            {
                calculadora.ResultadoDoLancamento = LeiaInt(calculadora.ResultadoDoLancamento, "Rolagem inicial de 4d6");
                calculadora.DividirPor = LeiaDouble(calculadora.DividirPor, "Dividir por");
                calculadora.AddValor = LeiaInt(calculadora.AddValor, "Adicionar valor");
                calculadora.Minimo = LeiaInt(calculadora.Minimo, "Mínimo");

                calculadora.CalcularPontuacaoDeHabilidade();

                Console.WriteLine("Pontuação de habilidade calculada: " + calculadora._pontuacao);
                Console.WriteLine("Pressione Q para sair, qualquer outra tecla para continuar");
                char caractereChar = Console.ReadKey(true).KeyChar;

                if ((caractereChar == 'Q') || (caractereChar == 'q')) return;
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


            static double LeiaDouble(double ultimoValorUsado, string prompt)
            {

                Console.Write($"{prompt} [{ultimoValorUsado}]: ");
                string linha = Console.ReadLine();

                if (double.TryParse(linha, out double valor))
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
