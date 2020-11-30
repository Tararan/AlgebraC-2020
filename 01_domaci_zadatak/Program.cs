using System;

namespace _01_domaci_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //4.1.2 - Ispis brojeva
            //Napišite program koji na konzoli ispisuje
            //brojeve 1,2,3 svaki u novi red.
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);

            //4.1.3 - Ledište/Vrelište
            //Napišite program koji će ispisivati temperaturu ledišta i vrelišta
            //vode, svaku u novi red
            int lediste = 0;
            int vreliste = 100;
            Console.WriteLine("Ledište vode: {0}°C", lediste);
            Console.WriteLine("Vrelište vode: {0}°C", vreliste);


            //5.1.1 - Zbroj i razlika
            //Program koji traži unos 2 cijela broja i prikazuje
            //na ekranu njihov zbroj te razliku
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("> Addition and subtraction");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Enter first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y;
            int difference = x - y;

            Console.WriteLine("Sum of numbers {0} and {1} is: {2} and their difference is: {3}", x, y, sum, difference);

            //5.1.2 - Umnožak i kvocijent
            //Program koji traži unos 2 cijela broja i prikazuje 
            //umnožak i kvocijent
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("> Multiplication and division");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");

            int b = Convert.ToInt32(Console.ReadLine());
            int product = a * b;
            float quotient = (float)a/b;

            Console.WriteLine("Product of numbers {0} and {1} is: {2} and their quotient is: {3}", a, b, product, quotient);
        }
    }
}
