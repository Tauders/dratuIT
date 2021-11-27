using System;
using System.Collections.Generic;

namespace Subtask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            List<string> words = new List<string>();
            Console.WriteLine("Введите любое количество слов, для остановки введите X");
            while (input != "X")
            {
                input = Console.ReadLine();
                words.Add(input);
            }
            Console.WriteLine("Данные введены, выберите способ сортировки (asc, desc)");
            string method = Console.ReadLine();
            if (method == "asc")
            {
                words.Sort();
            }
            else if (method == "desc")
            {
                words.Sort();
                words.Reverse();
            }
            else
            {
                Console.WriteLine("Данное действие не поддерживается");
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
