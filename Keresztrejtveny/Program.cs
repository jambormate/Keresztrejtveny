namespace Keresztrejtveny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KeresztrejtvenyRacs racs = new KeresztrejtvenyRacs("kr1.txt");

			Console.WriteLine("5. feladat: A keresztrejtvény mérete");
			Console.WriteLine($"\tSorok száma: {racs.SorokDb}");
			Console.WriteLine($"\tOszlopok száma: {racs.OszlopokDb}");

			Console.WriteLine("6. feladat: A beolvasott keresztrejtvény");
			racs.Megjelenit();

			Console.WriteLine($"7. feladat: A leghosszabb függ.: {racs.LeghosszabbFuggoleges()} karakter");
		}
    }
}
