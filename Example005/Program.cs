using System;

namespace Example005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное 3-значное число: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            if (Num>99 && Num<1000)
            {
                int z = Num % 10;
                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine("Введенное число не соответствует условию задачи.");
            }
        }
    }
}
