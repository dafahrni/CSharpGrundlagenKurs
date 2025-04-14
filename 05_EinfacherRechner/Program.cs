using System;

namespace EinfacherRechner
{
    class Rechner
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Einfacher Rechner");
            Console.Write("Zahl 1: ");
            double zahl1 = double.Parse(Console.ReadLine());

            Console.Write("Operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Zahl 2: ");
            double zahl2 = double.Parse(Console.ReadLine());

            double ergebnis = 0;

            if (op == "+")
                ergebnis = zahl1 + zahl2;
            else if (op == "-")
                ergebnis = zahl1 - zahl2;
            else if (op == "*")
                ergebnis = zahl1 * zahl2;
            else if (op == "/")
                ergebnis = zahl2 != 0 ? zahl1 / zahl2 : double.NaN;
            else
                Console.WriteLine("Unbekannter Operator!");

            Console.WriteLine($"Ergebnis: {ergebnis}");
        }
    }
}
