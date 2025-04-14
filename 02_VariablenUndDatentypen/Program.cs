using System;

namespace VariablenUndDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Max";
            int alter = 25;
            double kontostand = 150.75;
            bool istStudent = true;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Alter: {alter}");
            Console.WriteLine($"Kontostand: {kontostand} €");
            Console.WriteLine($"Ist Student: {istStudent}");
        }
    }
}
