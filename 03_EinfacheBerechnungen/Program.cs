using System;

namespace EinfacheBerechnungen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib eine Zahl ein: ");
            int zahl1 = int.Parse(Console.ReadLine());

            Console.Write("Gib eine zweite Zahl ein: ");
            int zahl2 = int.Parse(Console.ReadLine());

            int summe = zahl1 + zahl2;
            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {summe}.");
        }
    }
}
