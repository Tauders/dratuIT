using System;
using System.Collections.Generic;

namespace Subtask_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел (от 10 до 1000)");
            Random randomNumber = new Random();
            bool isUnknownNumber = true;
            int numbersLength = 0;
            while (isUnknownNumber)
            {
                string inputNumberLength = Console.ReadLine();
                if (int.TryParse(inputNumberLength, out numbersLength))
                {
                    if ((numbersLength < 10) || (numbersLength > 1000))
                    {
                        Console.WriteLine("Введенное вами число вне диапазона");
                    }
                    else
                    {
                        isUnknownNumber = false;
                    }
                } 
                else
                {
                    Console.WriteLine("Вы указали не числовое значение. Повторите ввод");
                }
            }
            HashSet<int> numbers = new HashSet<int>();
            Console.WriteLine("Количество чисел получено");
            for (int i = 0; i < numbersLength; i++)
            {
                numbers.Add(randomNumber.Next(1, 101));
            }

            int max = 0;
            int min = int.MaxValue;
            int result = 0;
            Console.WriteLine("Уникальные значения:");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
                if (max < number)
                    max = number;

                if (min > number)
                    min = number;

                result += number;
            }

            double midNumber = Math.Round(((double)result / numbers.Count), 1);
            Console.WriteLine();
            Console.WriteLine($"Минимальное значение = {min}");
            Console.WriteLine($"Максимальное значение значение = {max}");
            Console.WriteLine($"Среднее значение = {midNumber}");

            Console.ReadLine();
        }
    }
}
