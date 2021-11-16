using System;

namespace Subtask_2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int Actions(string action, int[] volumes)
            {
                int result = 0;

                if (action == "+")
                {
                    for (int i=0; i<volumes.Length; i++)
                    {
                        result += volumes[i]; 
                    }

                }

                else if (action == "-")
                {
                    for (int i = 0; i < volumes.Length; i++)
                    {
                        result -= volumes[i];
                    }
                }

                else if (action == "*")
                {
                    for (int i = 0; i < volumes.Length; i++)
                    {
                        result *= volumes[i];
                    }
                }

                else if (action == "/")
                {
                    for (int i = 0; i < volumes.Length; i++)
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
            int counter = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if ((Int32.TryParse(input, out index)) & (index < numbers.Length))
                {
                    Console.WriteLine($"Под индексом {index} находится число {numbers[index]}");
                    counter++;
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

            Console.Clear();
            int[] volumes = new int[counter];
            string action = Console.ReadLine();
            int result = Actions(action, volumes);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
