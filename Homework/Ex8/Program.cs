using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int count = 1;

            while (count<=Number)
            {
                if(count%2==0)
                {
                    Console.WriteLine(count);
                    count++;
                }
                else
                {
                    count++;
                }
            }

        }
    }
}
