using System;

namespace Example001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");

            int Num = Convert.ToInt32(Console.ReadLine());
            int Square = Num * Num;

            Console.WriteLine(Square);
        }
    }
}
