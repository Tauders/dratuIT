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
            bool isNotError = true;
            while (isNotError)
            {
                string inputNumberLenth = Console.ReadLine();
                if (int.TryParse(inputNumberLenth, out int numbersLenth))
                {
                    if ((numbersLenth < 10) || (numbersLenth > 1000))
                    {
                        Console.WriteLine("Введенное вами число вне диапозона");
                    }
                    else
                    {
                        List<int> numbers = new List<int>();
                        Console.WriteLine("Количество чисел получено");
                        int max = 0;
                        double result = 0;
                        for (int i = 0; i < numbersLenth; i++)
                        {
                            numbers.Add(rnd.Next(1, 101));
                            int tempNumber = numbers[i];
                            if (max < tempNumber)
                            {
                                max = tempNumber;
                            }

                            result += numbers[i];
                            Console.Write(numbers[i] + " ");
                        }

                        int min = max;
                        for (int i = 0; i < numbersLenth; i++)
                        {
                            int tempNumber = numbers[i];
                            if (min > tempNumber)
                            {
                                min = tempNumber;
                            }
                        }
                        isNotError = false;

                        IEnumerable<int> distinctNumbers = numbers.Distinct();
                        double midValue = Math.Round((result / numbersLenth), 1);
                        Console.WriteLine("\nУникальные значения:");
                        foreach (int number in distinctNumbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.WriteLine($"\nМинимально значение = {min}");
                        Console.WriteLine($"Максимальное значение = {max}");
                        Console.WriteLine($"Среднее значение = {midValue}");
                    }
                } 
                else
                {
                    Console.WriteLine("Вы указали данные в другом формате");
                }
            }
            Console.ReadLine();
        }
    }
}
