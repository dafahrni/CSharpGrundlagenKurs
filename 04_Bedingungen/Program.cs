using System;

namespace Bedingungen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie alt bist du? ");
            int alter = int.Parse(Console.ReadLine());

            if (alter >= 18)
            {
                Console.WriteLine("Du bist volljährig.");
            }
            else
            {
                Console.WriteLine("Du bist noch nicht volljährig.");
            }
        }
    }
}
