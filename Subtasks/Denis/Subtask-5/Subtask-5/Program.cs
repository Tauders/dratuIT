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
                        for (int i = 0; i < numbersLenth; i++)
                        {
                            numbers.Add(rnd.Next(1, 101));
                            isNotError = false;
                        }
                        IEnumerable<int> ts = numbers.Distinct();
                        List<int> test = ts.ToList();
                        Console.WriteLine("Уникальные значения:");
                        foreach (int number in test)
                        {
                            Console.Write(number +" ");
                        } 
                        
                        int max = 0;
                        double result = 0;
                        for (int i = 0; i < test.Count; i++)
                        {
                            int tempNumber = test[i];
                            if (max < tempNumber)
                            {
                                max = tempNumber;
                            }
                            result += test[i];

                        }
                        double midNumber = Math.Round((result / test.Count),1);
                        int min = max;
                        for (int i = 0; i < test.Count; i++)
                        {
                            int tempNumber = test[i];
                            if (min > tempNumber)
                            {
                                min = tempNumber;
                            }
                        }
                        Console.WriteLine($"\nМинимальное значение = {min}");
                        Console.WriteLine($"Максимальное значение значение = {max}");
                        Console.WriteLine($"Среднее значение = {midNumber}");
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
