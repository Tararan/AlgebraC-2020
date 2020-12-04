using System;

namespace _06_Nizovi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nizovi");
            int[] brojevi = new int[3]; //1-dimenzionalno polje
            brojevi[0] = 19;
            brojevi[1] = 29;
            brojevi[1] = 39;

            Console.WriteLine("Drugi element ima vrijednost:" + brojevi[2]);

            // >< [ ] { }
            for (int i=0; i < brojevi.Length; i ++)
            {
                Console.WriteLine("{0} element ima vrijednost {1}", i, brojevi[i]);
            }

            foreach (var item in brojevi)
            {
                Console.WriteLine(item.GetType() + " vrijednost:" + item);
            }

            Console.WriteLine("Unesite 10 brojeva");

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("unsei {0}. broj", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Unijeli ste sljedeće brojeve");
            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
