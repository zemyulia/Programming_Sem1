using System;

namespace Example003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в диапазоне от 1 до 7:");
            int Num = Convert.ToInt32(Console.ReadLine());
            

            if(Num > 0 && Num<8)
            {
                if(Num == 1)
                {
                    Console.WriteLine("Понедельник");
                }

                if(Num == 2)
                {
                    Console.WriteLine("Вторник");
                }

                if(Num == 3)
                {
                    Console.WriteLine("Среда");
                }

                if(Num == 4)
                {
                    Console.WriteLine("Четверг");
                }

                if(Num == 5)
                {
                    Console.WriteLine("Пятница");
                }

                if(Num == 6)
                {
                    Console.WriteLine("Суббота");
                }

                if(Num == 7)
                {
                    Console.WriteLine("Воскресенье");
                }

            }
            else
            {
                Console.WriteLine("Введенное число не входит в диапазон от 1 до 7.");
                Console.WriteLine("Введите другое число.");
            }
        }
    }
}
