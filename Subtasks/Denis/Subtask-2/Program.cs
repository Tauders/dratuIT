﻿using System;
using System.Collections.Generic;

namespace Subtask_2
{
    
    class Program
    {
        public static int GetResult (string action, List<int> valuesOfNumbers)
        {
            int result = valuesOfNumbers[0];
            switch (action) 
            {
                case "+":
                    for (int i = 1; i < valuesOfNumbers.Count; i++)
                    {
                        result += valuesOfNumbers[i];
                    }
                    break;

                case "-":
                    for (int i = 1; i < valuesOfNumbers.Count; i++)
                    {
                        result -= valuesOfNumbers[i];
                    }
                    break;

                case "*":
                    for (int i = 1; i < valuesOfNumbers.Count; i++)
                    {
                        result *= valuesOfNumbers[i];
                    }
                    break;

                case "/":
                    for (int i = 1; i < valuesOfNumbers.Count; i++)
                    {
                        if (valuesOfNumbers[i] == 0)
                        {
                            Console.WriteLine("Делить на 0 нельзя");
                        }

                        else
                        {
                            result /= valuesOfNumbers[i];
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Введено некорректное действие");
                    break;
            }
            return result;
        }


        static void Main(string[] args)
        {

            Random rnd = new Random();
            int n = rnd.Next(3, 7);
            int[] numbers = new int[n];
            Console.WriteLine($"Программа сгенерировала список из {n} чисел");

            int number = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                string inputNumber = Console.ReadLine();
                if (Int32.TryParse(inputNumber, out number))
                {
                    numbers[i] = number; ;
                }

                else
                {
                    Console.WriteLine("Некорректный ввод");
                    if (i >= 0)
                    {
                        i--;
                    }
                }
            }

            Console.Write($"Числа введены, выберите доступные: ");
            for (int i =0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            int index = 0;
            List<int> valuesOfNumbers = new List<int>();
            while (true)
            {
                string input = Console.ReadLine();
                if ((Int32.TryParse(input, out index)) && (index < numbers.Length))
                {
                    Console.WriteLine($"Выбранное вами число: {numbers[index]}");
                    valuesOfNumbers.Add(numbers[index]);
                }

                else if (input == "X")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }

            Console.WriteLine("Числа выбраны, введите необходимое действие: +, -, *, /");
            string action = Console.ReadLine();
            while (true)
            {
                if ((action == "+") || (action == "-") || (action == "*") || (action == "/"))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Действие не выбрано");
                    break;
                }
            }

            int result = GetResult(action, valuesOfNumbers);

            Console.WriteLine($"Действие выбрано, результат - {result}");
            Console.WriteLine("Завершение работы");
        }
    }
}
