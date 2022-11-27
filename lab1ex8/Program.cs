using System;

namespace lab1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            //citim doua numere si verificam daca x este divizibil cu y
            int x, y;
            Console.WriteLine("Introduceti doua numere ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (y == 0) Console.WriteLine("indivizibil");
            else if (x % y == 0) Console.WriteLine("divizibil");
            else Console.WriteLine("indivizibil");
        }
    }
}
