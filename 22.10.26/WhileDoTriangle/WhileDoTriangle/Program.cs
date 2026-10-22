using System;

namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk");

            int n = 5;
            int i = 1;

            while (i <= n)
            {
                int veerg = 1;

                while (veerg <= i)
                {
                    Console.Write("*");
                    veerg++;
                }

                Console.WriteLine();
                i++;
            }

            Console.ReadLine();
        }
    }
}
