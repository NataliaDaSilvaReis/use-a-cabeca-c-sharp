
namespace MeuPrimeiroAppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExemplosOperadores();
        }

        private static void ExemplosOperadores()
        {
            // Declara uma variável e a define para 3.
            int largura = 3;

            // O operador ++ aumenta uma variável em 1.
            largura++;

            // Declara mais duas variáveis e usa os operadores + e * para adicionar e multiplicar valores.
            int altura = 2 + 4;
            int area = largura * altura;
            Console.WriteLine(area);

            while (area < 20)
            {
                altura++;
                area = largura * altura;
            }

            do
            {
                largura--;
                area = largura * altura;
            } while (area > 25);

            // Declaram variáveis e usa + para concatenar.
            string resultado = "A área";
            resultado = resultado + " é " + area;
            Console.WriteLine(resultado);

            // Uma variável booleana é true ou false.
            bool valorVerdadeiro = true;
            Console.WriteLine(valorVerdadeiro);


            // Loop 3: testando depurador.
            int p = 2;
            for (int q = 2; q < 32; q = q * 2)
            {
                while (p < q)
                {
                    p = p * 2;
                }
                q = p - q;
            }
        }
    }
}
