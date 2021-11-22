using System;
using System.Collections.Generic;

namespace Subtask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            Console.WriteLine("Введите любое количество слов, для остановки введите X");
            while (true)
            {
                string word = Console.ReadLine();
                if (word != "X")
                {
                    words.Add(word);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Данные введены, выберите способ сортировки (asc, desc)");
            string method = Console.ReadLine();
            if (method == "asc")
            {
                words.Sort();
                foreach (string word in words)
                {
                    Console.WriteLine(word);    
                }
            }
            else if (method == "desc")
            {
                words.Sort();
                words.Reverse();
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }
            }
            else
            {
                Console.WriteLine("Данное действие не поддерживается");
            }

            Console.WriteLine("Все значения выведены");
            Console.ReadKey();
        }
    }
}
