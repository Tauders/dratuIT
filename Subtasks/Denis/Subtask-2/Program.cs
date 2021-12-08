using System;
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
            int numbersIndex = 0;
            Random rnd = new Random();
            int n = rnd.Next(3, 7);
            int[] numbers = new int[n];
            
            Console.WriteLine($"Программа сгенерировала список из {n} чисел");

            while (numbersIndex < numbers.Length)
            {
                int number = 0;
                string inputNumber = Console.ReadLine();
                string[] tempNumbers = inputNumber.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (!String.IsNullOrWhiteSpace(inputNumber))
                {
                    for (int tempIndex = 0; tempIndex < tempNumbers.Length; tempIndex++, numbersIndex++)
                    {
                        if (Int32.TryParse(tempNumbers[tempIndex], out number))
                        {
                            numbers[numbersIndex] = number;
                        }
                        else
                        {
                            bool isDigit = false;
                            while (!isDigit)
                            {
                                Console.WriteLine($"Вы указали неверные данный, повторите ввод {numbersIndex + 1} -го числа");
                                tempNumbers[tempIndex] = Console.ReadLine();
                                if (Int32.TryParse(tempNumbers[tempIndex], out number))
                                {
                                    isDigit = true;
                                    numbers[numbersIndex] = number;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Вы ничего не ввели");
                }
            }
            Console.Write($"Числа введены, выберите доступные: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            string input = null;
            List<int> valuesOfNumbers = new List<int>();
            while (input != "X")
            {
                input = Console.ReadLine();
                int index = 0;
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Вы ничего не ввели");
                }
                else
                {
                    if (input == "X")
                    {
                        Console.WriteLine("Числа выбраны, введите необходимое действие: +, -, *, /");
                    }
                    else if (((Int32.TryParse(input, out index)) && (index < numbers.Length) && (index >= 0)))
                    {
                        Console.WriteLine($"Выбранное вами число: {numbers[index]}");
                        valuesOfNumbers.Add(numbers[index]);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод");
                    }
                }
            }

            bool isAction = false;
            while (!isAction)
            {
                string inputAction = Console.ReadLine();
                if ((inputAction == "+") || (inputAction == "-") || (inputAction == "*") || (inputAction == "/"))
                {
                    isAction = true;
                    int result = GetResult(inputAction, valuesOfNumbers);
                    Console.WriteLine($"Действие выбрано, результат - {result}");
                }
                else
                {
                    Console.WriteLine("Данное действие не поддерживается");
                }
            }
            Console.WriteLine("Завершение работы");
            Console.ReadKey();
        }
    }
}