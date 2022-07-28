using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            if(Number%2==0)
            {
                Console.WriteLine("Введенное число - четное.");
            }
            else
            {
                Console.WriteLine("Введенное число - нечетное.");
            }
        }
    }
}
