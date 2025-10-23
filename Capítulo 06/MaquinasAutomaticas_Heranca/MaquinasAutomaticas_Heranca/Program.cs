namespace MaquinasAutomaticas_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MaquinaAutomatica maquinaAutomatica = new MaquinaDeRacaoAnimal();
            Console.WriteLine(maquinaAutomatica.Dispensar(2.00M));

        }
    }
}
