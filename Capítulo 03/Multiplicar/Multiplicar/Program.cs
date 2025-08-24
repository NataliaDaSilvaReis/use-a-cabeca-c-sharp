namespace Multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Multiplicar(int fator1, int fator2)
            {
                int produto = fator1 * fator2;

                return produto;
            }

            int altura = 179;
            int largura = 83;
            int area = Multiplicar(altura, largura);
        }
    }
}
