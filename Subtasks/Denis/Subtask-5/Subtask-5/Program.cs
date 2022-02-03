using System;
using System.Collections.Generic;

namespace Subtask_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numbersLenth = rnd.Next(10, 1001);
            int[] numbers = new int[numbersLenth];
            int min = 100;
            int max = 0;
            double middle = 0;
            double result = 0;
            for (int i = 0; i < numbersLenth; i++)
            {
                numbers[i] = rnd.Next(1, 101);
                int temp = numbers[i];
                Console.Write(numbers[i] + " ");
                if (min > temp)
                {
                    min = temp;
                }
                else if (max < temp)
                {
                    max = temp;
                }
                result += numbers[i] ;
            }
            middle = result / numbersLenth;

            Console.WriteLine($"\nМинимальное значение: {min}, Максимальное значение: {max}, Среднее значение {middle}");
            Console.ReadLine();

        } 
    }
}
