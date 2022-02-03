using System;
using System.Collections.Generic;
using System.Linq;

namespace Subtask_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел (от 10 до 1000)");
            Random rnd = new Random();
            string inputNumberLenth = Console.ReadLine();
            if(int.TryParse(inputNumberLenth, out int numbersLenth))
            {
                List<int> number = new List<int>();
                Console.WriteLine("Количество чисел получено");
                int[] numbers = new int[numbersLenth];
                int min = 100;
                int max = 0;
                double result = 0;
                for (int i = 0; i < numbersLenth; i++)
                {
                    numbers[i] = rnd.Next(1, 101);
                    int temp = numbers[i];
                    if (min > temp)
                    {
                        min = temp;
                    }
                    else if (max < temp)
                    {
                        max = temp;
                    }
                    else if (numbers[i-1] != numbers[i])
                    {
                        number.Add(numbers[i]);
                    }
                    result += numbers[i];
                    Console.Write(numbers[i] + " ");
                }

                double middle = result / numbersLenth;
                Console.WriteLine($"\nМинимально значение = {min}");
                Console.WriteLine($"Максимальное значение = {max}");
                Console.WriteLine($"Среднее значение = {middle}");
            }
            else
            {
                Console.WriteLine("Вы указали данные в другом формате");
            }
            Console.ReadLine();
        } 
    }
}
