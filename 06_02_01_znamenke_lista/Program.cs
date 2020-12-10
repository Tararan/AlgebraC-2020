using System;
using System.Collections.Generic;

namespace _06_02_01_znamenke_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molim unesite cijelobrojni broj");
            List<int> znamenke = new List<int>();
            int broj = int.Parse(Console.ReadLine());

            while (broj>0)
            {
                znamenke.Add(broj % 10);
                broj = broj /= 10;
            }

            Console.WriteLine("Prije okretanja");
            foreach (var item in znamenke)
            {
                Console.Write("{0} ", item);
            }

            znamenke.Reverse();
            Console.WriteLine("Nakon okretanja");

            foreach (var item in znamenke)
            {
                Console.Write("{0} ", item);
            }
           
        }
    }
}
