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
                List<int> numbers = new List<int>();
                Console.WriteLine("Количество чисел получено");
                int min = 100;
                int max = 0;
                double result = 0;
                for (int i = 0; i < numbersLenth; i++)
                {
                    numbers.Add(rnd.Next(1, 101));
                    int tempNumber = numbers[i];
                    if (min > tempNumber)
                    {
                        min = tempNumber;
                    }
                    else if (max < tempNumber)
                    {
                        max = tempNumber;
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
