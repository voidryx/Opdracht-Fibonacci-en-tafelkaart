
using System;

namespace Opdracht_Fibonacci_en_tafelkaart
{
    internal class Program
    {
        static void Fibonacci(int n)
        {
            int a = 1;
            int b = 2;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine();
        }

        static void Tafelkaart(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i * j + "\t");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Geef een getal voor Fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Fibonacci(n);

            Console.WriteLine();

            Console.Write("Geef een getal voor de tafelkaart: ");
            n = Convert.ToInt32(Console.ReadLine());
            Tafelkaart(n);
        }
    }
}
