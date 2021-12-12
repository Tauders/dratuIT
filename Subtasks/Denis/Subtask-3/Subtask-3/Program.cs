using System;
using System.Collections.Generic;

namespace Subtask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tempInput = null;
            List<string> words = new List<string>();
            Console.WriteLine("Введите любое количество слов, для остановки введите X");
            while (tempInput == null)
            {
                string input = Console.ReadLine();
                if (input != "X")
                {
                    words.Add(input);
                }
                else
                {
                    tempInput = "X";
                }
            }
            Console.WriteLine("Данные введены, выберите способ сортировки (asc, desc)");

            string method = null;
            string tempMethod = null;
            while (method == null)
            {
                method = Console.ReadLine();
                if ((method == "asc") || (method == "desc"))
                {
                    tempMethod = method;
                    if (tempMethod == "asc")
                    {
                        words.Sort();
                    }
                    else if (tempMethod == "desc")
                    {
                        words.Sort();
                        words.Reverse();
                    }

                    foreach (string word in words)
                    {
                        Console.WriteLine(word);
                    }
                }
                else
                {
                    Console.WriteLine("Данное действие не поддерживается");
                }
            }

            Console.WriteLine("Все значения выведены");
            Console.ReadKey();
        }
    }
}