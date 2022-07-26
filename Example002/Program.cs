using System;

namespace Example002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число:");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите второе число:");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            
            if(Num1 == Num2 * Num2)
            {
                Console.WriteLine("Первое число является квадратом второго");
                Console.WriteLine(("(то есть результатом умножения второго числа на самого себя)"));
            }

            else
            {
                Console.WriteLine("Первое число не является квадратом второго");
                Console.WriteLine(("(то есть результатом умножения второго числа на самого себя)"));
            }
            
        }
    }
}
