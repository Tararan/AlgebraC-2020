using System;

namespace _01_logicki_operatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username and pass");
            Console.WriteLine("Unesi ime");
            string uname = Console.ReadLine().ToLower();
            Console.WriteLine("Unesi pass");
            string pass = Console.ReadLine();



            if(uname == "Pero" && pass == "123")
            {
                Console.WriteLine("Korisnik je logiran");
            }
            else 
            {
                Console.WriteLine("Korisničko ime i/ili pass je neispravan");
            }
        }
    }
}
