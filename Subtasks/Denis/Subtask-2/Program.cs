using System;
using System.Collections.Generic;

namespace Subtask_2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int Actions(string action, List<int> volumes)
            {
                int result = 0;

                if (action == "+")
                {
                    for (int i=0; i<volumes.Count; i++)
                    {
                        result += volumes[i]; 
                    }

                }

                else if (action == "-")
                {
                    for (int i = 0; i < volumes.Count; i++)
                    {
                        result -= volumes[i];
                    }
                }

                else if (action == "*")
                {
                    for (int i = 0; i < volumes.Count; i++)
                    {
                        result *= volumes[i];
                    }
                }

                else if (action == "/")
                {
                    for (int i = 0; i < volumes.Count; i++)
                    {
                        result /= volumes[i];
                    }
                }

                return result;
            }


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
            List<int> volumes = new List<int>();
            while (true)
            {
                string input = Console.ReadLine();

                if ((Int32.TryParse(input, out index)) & (index < numbers.Length))
                {
                    Console.WriteLine($"Выбранное вами число: {numbers[index]}");
                    volumes.Add(numbers[index]);
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
                    Console.WriteLine("Не корректный ввод");
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
            int result = Actions(action, volumes);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
