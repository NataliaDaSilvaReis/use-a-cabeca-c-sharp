namespace RouboDeJoias_VirtualEOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DonoDoCofre dono = new DonoDoCofre();
            Cofre cofre = new Cofre();
            LadraoDeJoias ladraoDeJoias = new LadraoDeJoias();

            ladraoDeJoias.AbrirCofre(cofre, dono);
            Console.ReadKey(true);
        }
    }
}
