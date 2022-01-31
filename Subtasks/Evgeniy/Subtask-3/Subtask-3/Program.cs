using System;
using System.Collections.Generic;

namespace Subtask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите построчно слова для дальнейшей сортировки");
            string userInput = "";
            List<string> aSetOfWords = new List<string>();
            while (userInput.ToLower() != "exit")
            {
                userInput = Console.ReadLine();
                if (userInput.ToLower() != "exit")
                {
                    aSetOfWords.Add(userInput);
                }
            }
            int count = 0;
            string[] words = new string[aSetOfWords.Count];
            foreach (string aSetOfWord in aSetOfWords)
            {
                words[count] = aSetOfWords[count];
                count++;
            }
            Console.WriteLine("Введите asc или desc для выбора сортировки");
            string sortSelection = Console.ReadLine();
            if (sortSelection.ToLower() == "asc")
            {
                Array.Sort(words);
                Array.ForEach(words, Console.WriteLine);
            }
        }
    }
}
