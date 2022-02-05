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
                string inputNumberLength = Console.ReadLine();
                if (int.TryParse(inputNumberLength, out int numbersLength))
                {
                    if ((numbersLength < 10) || (numbersLength > 1000))
                    {
                        Console.WriteLine("Введенное вами число вне диапозона");
                    }
                    else
                    {
                        HashSet<int> numbers = new HashSet<int>();
                        Console.WriteLine("Количество чисел получено");
                        for (int i = 0; i < numbersLength; i++)
                        {
                            numbers.Add(rnd.Next(1, 101));
                        }
                        isNotError = false;
                        int max = numbers.SelectMany(max => numbers).Max();
                        int min = numbers.SelectMany(min => numbers).Min();
                        double result = 0;
                        Console.WriteLine("Уникальные значения:");
                        foreach (int number in numbers)
                        {
                            Console.Write($"{number} ");
                            result += number;
                        }
                        
                        double midNumber = Math.Round((result / numbers.Count), 1);
                        Console.WriteLine();
                        Console.WriteLine($"Минимальное значение = {min}");
                        Console.WriteLine($"Максимальное значение значение = {max}");
                        Console.WriteLine($"Среднее значение = {midNumber}");
                    }
                } 
                else
                {
                    Console.WriteLine("Вы указали не числовое значение. Повторите ввод");
                }
            }
            Console.ReadLine();
        }
    }
}
