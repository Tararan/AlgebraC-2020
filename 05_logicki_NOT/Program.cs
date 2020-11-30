using System;

namespace _05_logicki_NOT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime škole (Algebra)");
            string imeskole = Console.ReadLine().ToLower();
            if(! (imeskole == "algebra"))
            {
                Console.WriteLine("Algebra!");
            }
            else
            {
                Console.WriteLine("Sve OK");
            }                
        }
    }
}
