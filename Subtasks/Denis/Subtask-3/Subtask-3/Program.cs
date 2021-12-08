using System;
using System.Collections.Generic;

namespace Subtask_3
{
    
    internal class Program
    {
        public static List<string> GetSort(List<string> words, string method)
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
            bool isExit = false;
            List<string> words = new List<string>();
            Console.WriteLine("Введите любое количество слов, для остановки введите X");
            while (!isExit)
            {
                string input = Console.ReadLine();
                if (input == "X")
                {
                    isExit = true;
                    Console.WriteLine("Данные введены, выберите способ сортировки (asc, desc)");
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
                    GetSort(words, method);
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
