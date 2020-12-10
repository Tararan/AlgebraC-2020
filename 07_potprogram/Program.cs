using System;

namespace _07_potprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozdrav iz Main metode!");
            Hello();
            Hello();
            Hello();
        }

        static void Hello()
        {
            Console.WriteLine("Pozdrav iz potprograma");
        }
    }
}
