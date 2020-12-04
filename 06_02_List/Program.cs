using System;
using System.Collections.Generic;

namespace _06_02_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genericke liste");
            List<int> listabrojeva = new List<int>();
            int broj = -1;
            while (broj != 0)
            {
                broj = int.Parse(Console.ReadLine());
                listabrojeva.Add(broj);
            }
        }
    }
}
