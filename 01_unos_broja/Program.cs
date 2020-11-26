using System;

namespace _01_unos_broja
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            broj = 15;
            Console.WriteLine(broj);
            try
            {
                broj = int.Parse(Console.ReadLine());
            }
        }
    }
}
