using System;
using System.Collections.Generic;

namespace Subtask_3
{
    internal class Program
    {

        public static void SortListByMethod(string method, List<string> words)
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
        }

        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            Console.WriteLine("Введите любое количество слов, для остановки введите X");
            bool isExit = false;
            while (!isExit)
            {
                string input = Console.ReadLine();
                if (input == "X")
                {
                    Console.WriteLine("Данные введены, выберите способ сортировки (asc, desc)");
                    isExit = true;
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
                if ((method == "asc") || (method == "desc"))
                {
                    SortListByMethod(method, words);
                    isSelect = true;
                }
                else
                {
                    Console.WriteLine("Данное действие не поддерживается");
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