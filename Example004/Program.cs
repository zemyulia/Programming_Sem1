using System;

namespace Example004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int x = (-N);

            while(x<(N+1) && x> -(N+1))
            {
                Console.Write(x);
                Console.Write(" ,");
                x++;

            }

        }
    }
}
