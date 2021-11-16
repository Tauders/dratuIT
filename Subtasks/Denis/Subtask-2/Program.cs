using System;

namespace Subtask_2
{
    class Program
    {
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
            while (true)
            {
                string input = Console.ReadLine();

                if ((Int32.TryParse(input, out index)) & (index < numbers.Length))
                {
                    Console.WriteLine($"Под индексом {index} находится число {numbers[index]}");
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



            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
