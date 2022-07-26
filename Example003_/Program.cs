using System;

namespace Example003_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в диапазоне от 1 до 7:");
            int Num = Convert.ToInt32(Console.ReadLine());

            switch (Num)
            {
                case 1: Console.WriteLine("Понедельник");
                break;
            }

            switch (Num)
            {
                case 2: Console.WriteLine("Вторник");
                break;
            }

            switch (Num)
            {
                case 3: Console.WriteLine("Среда");
                break;
            }

            switch (Num)
            {
                case 4: Console.WriteLine("Четверг");
                break;
            }

            switch (Num)
            {
                case 5: Console.WriteLine("Пятница");
                break;
            }

            switch (Num)
            {
                case 6: Console.WriteLine("Суббота");
                break;
            }

            switch (Num)
            {
                case 7: Console.WriteLine("Воскресенье");
                break;
            }
            default:
                Console.WriteLine("Введенное число не входит в диапазон от 1 до 7.");
                Console.WriteLine("Введите другое число.");
        }
    }
}
