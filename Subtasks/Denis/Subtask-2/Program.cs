using System;
using System.Collections.Generic;

namespace Subtask_2
{
    
    class Program
    {
        public static int GetAction(string action, List<int> valuesOfNumbers)
        {
            int result = valuesOfNumbers[0];
            if (action == "+")
            {
                for (int i = 1; i < valuesOfNumbers.Count; i++)
                {
                    result += valuesOfNumbers[i];
                }
            }

            else if (action == "-")
            {
                for (int i = 1; i < valuesOfNumbers.Count; i++)
                {
                    result -= valuesOfNumbers[i];
                }
            }

            else if (action == "*")
            {
                for (int i = 1; i < valuesOfNumbers.Count; i++)
                {
                    result *= valuesOfNumbers[i];
                }
            }

            else if (action == "/")
            {
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
            }

            return result;
        }


        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int n = rnd.Next(3, 7);
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rnd.Next(1, 10);
            }

            Console.WriteLine($"Программа сгенерировала список из {n} чисел");

            Console.Write($"Числа введены, выберите доступные: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            int index = 0;
            List<int> valuesOfNumbers = new List<int>();
            while (true)
            {
                string input = Console.ReadLine();
                if ((Int32.TryParse(input, out index)) & (index < numbers.Length))
                {
                    Console.WriteLine($"Выбранное вами число: {numbers[index]}");
                    valuesOfNumbers.Add(numbers[index]);
                    if (numbers[index] == valuesOfNumbers[index])
                    {
                        Console.WriteLine("Это число вы уже выбрали");
                    }

                    else
                    {
                        
                    }

                    if (valuesOfNumbers.Count == numbers.Length)
                    {
                        Console.WriteLine("Вы выбрали все числа из списка");
                        break;
                    }
                }

                else if (index >= numbers.Length)
                {
                    Console.WriteLine("Вы ввели значение за пределами массива");
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
                if ((action == "+") | (action == "-") | (action == "*") | (action == "/"))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Действие не выбрано");
                }
            }

            int result = GetAction(action, valuesOfNumbers);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
