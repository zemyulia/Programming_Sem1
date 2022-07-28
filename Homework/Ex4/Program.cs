using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int NumA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int NumB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            int NumС = Convert.ToInt32(Console.ReadLine());

            int max = 0;

            if(NumA==NumB && NumB==NumС)
            {
                Console.WriteLine("Числа равны");
            }
            else
            {
               if(NumA>NumB && NumA>NumС)
                {
                    max = NumA;
                    Console.Write("Max = ");
                    Console.WriteLine(max);
                }
               
               else 
                    {
                        if(NumB>NumС && NumB>NumA)
                            {
                                max = NumB;
                                Console.Write("Max = ");
                                Console.WriteLine(max);
                            }
                        else 
                            {
                                if (NumС>NumA && NumС>NumB)
                                    {
                                        max = NumС;
                                        Console.Write("Max = ");
                                        Console.WriteLine(max);
                                    }
                            }
                    }

            }
        }
    }
}


