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
            List<string> SetOfWords = new List<string>();
            bool validUserInput = false;
            while (!validUserInput)
            {
                userInput = Console.ReadLine();
                if (userInput.ToLower() != "exit")
                {
                    SetOfWords.Add(userInput);
                }
                else
                {
                    validUserInput = true;
                }
            }
            Console.WriteLine("Введите asc или desc для выбора сортировки");
            string sortSelection = Console.ReadLine();
            if (sortSelection.ToLower() == "asc")
            {
                SetOfWords.Sort();
                foreach (var word in SetOfWords)
                {
                    Console.WriteLine(word);
                }
            }
            else if (sortSelection.ToLower() == "desc")
            {
                SetOfWords.Sort((str1, str2) => { return string.Compare(str2, str1); });
                foreach (var word in SetOfWords)
                {
                    Console.WriteLine(word);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение, значит вам нужно отдохнуть и больше не вводить значений");
            }
        }
    }
}
