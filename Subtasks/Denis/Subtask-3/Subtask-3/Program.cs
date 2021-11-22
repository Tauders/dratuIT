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
            if (method = "asc")
            {
                words.Sort();
            }
            else if (method = "desc")
            {

            }
            else
            {
                Console.WriteLine("Данное действие не поддерживается");
            }

            for (int i =0; i< words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }

            Console.ReadKey();
        }
    }
}
