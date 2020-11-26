using System;

namespace _01_increment_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Increment i decrement");
            double x = 1.5, y;
            y = 0;
            int z = 0;
            Console.WriteLine("y=" + y);
            y = x;
            Console.WriteLine("y=" + y);

            Console.WriteLine(" eksplicitna konverzija");
            z = (int)x;
            Console.WriteLine("z" + z);

            String s1 = Convert.ToString(x);

            Console.WriteLine("Ovo je pretvoreni broj x: " + x);

            Console.ForegroundColor = ConsoleColor.Red;
            double zz = x + Convert.ToDouble(s1);
            Console.WriteLine("zz=" + zz);
            Console.BackgroundColor = ConsoleColor.Gray;
        }
    }
}
