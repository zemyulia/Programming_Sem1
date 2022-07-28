using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int NumA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Второе число: ");
            int NumB = Convert.ToInt32(Console.ReadLine());

            if(NumA==NumB)
            {
                Console.WriteLine("Числа равны");
            }
            else
            {
                if(NumA>NumB)
                {
                    Console.Write("Max = ");
                    Console.WriteLine(NumA);
                }
                else
                {
                    Console.Write("Max = ");
                    Console.WriteLine(NumB);
                }
            }
        }
    }
}
