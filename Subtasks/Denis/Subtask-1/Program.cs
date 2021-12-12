﻿using System;
namespace Subtask_1

{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.WriteLine("Введите количество строк, которые хотите использовать");
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out n))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Введите числовое значение");
                }
            }

            string[] words = new string[n];
            Console.WriteLine($"Ваш массив будет состоять из {n} элементов");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i+1} элемент массива");
                words[i] = Console.ReadLine();
            }
            Console.WriteLine("Все строки введены, выберите строку для отображения");

            while (true)
            {
                try
                {
                    string value = Console.ReadLine();
                    if (value != "X")
                    {
                        int index = Convert.ToInt32(value);
                        if (index < words.Length)
                        {
                            Console.WriteLine(words[index]);
                        }

                        else
                        {
                            Console.WriteLine("Ошибка");
                        }
                    }

                    else
                    {
                        break;
                    }
                }

                catch
                {
                    Console.WriteLine("Указаны неверные данные");
                }
            }

            Console.WriteLine("Работа завершена");
            Console.ReadKey();
            }
    }
}

