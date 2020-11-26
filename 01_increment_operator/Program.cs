using System;

namespace _01_increment_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Increment i decrement");
            y = x;
            Console.WriteLine("y=" + y);


            // String s1 = (String)x;
            String s1 = Convert.ToString(x);

            Console.ForegroundColor = ConsoleColor.Red;
            double zz = x + Convert.ToDouble(s1);
            Console.WriteLine("zz=" + zz);
            Console.BackgroundColor = ConsoleColor.Gray;
            


        }
    }
}
