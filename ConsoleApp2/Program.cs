namespace ConsoleApp2
{
    internal class Program
    {
        static double AtlagTerfogat(List<Henger> hengerek)
        {
            double szumTerfogat = 0;
            foreach (var henger in hengerek)
            {
                szumTerfogat += henger.Terfogat();
            }
            return szumTerfogat / Henger.SzuletesSzamlalo;
        }

        static void Lista(List<Henger> hengerek)
        {
            foreach (var henger in hengerek)
            {
                Console.WriteLine(henger);
            }
        }
        static void Main(string[] args)
        {
            List<Henger> testek = new List<Henger>();
            testek.Add(new Henger(1, 4));
            testek.Add(new TomorHenger(0.5, 4, 2));
            testek.Add(new TomorHenger(0.5, 4));
            testek.Add(new Cso(5, 5, 0.5));
            testek.Add(new Cso(5, 5, 0.5, 2));
            Lista(testek);
            Console.WriteLine("Testek száma:" + testek.Count);
            Console.WriteLine("Létrehozott hengerek száma:" + Henger.SzuletesSzamlalo);
            Console.WriteLine($"Átlag térfogat: {AtlagTerfogat(testek):N2}");
        }
    }
}