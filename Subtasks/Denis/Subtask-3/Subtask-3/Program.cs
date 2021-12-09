using System;
using System.Collections.Generic;

namespace Subtask_3
{

    class Program
    {
        public static List<string> GetSort(string method, List<string> words)
        {
            switch (method)
            {
                case "asc":
                    words.Sort();
                    break;
                case "desc":
                    words.Sort();
                    words.Reverse();
                    break;
                default:
                    break;
            }
            return words;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое количество слов, для остановки введите X");
            bool isExit = false;
            List<string> words = new List<string>();
            while (!isExit)
            {
                string input = Console.ReadLine();
                if (input == "X")
                {
                    isExit = true;
                    Console.WriteLine("Данные введены, выберите способ сортировки (asc, desc)");
                }
                else if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Вы ничего не ввели");
                }
                else
                {
                    words.Add(input);
                }
            }

            bool isSelect = false;
            while (!isSelect)
            {
                string method = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(method))
                {
                    Console.WriteLine("Вы ничего не ввели");
                }
                else if ((method == "asc") || (method == "desc"))
                {
                    GetSort(method, words);
                    isSelect = true;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Все значения выведены");
            Console.ReadKey();
        }
    }
}