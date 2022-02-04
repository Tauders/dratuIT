using System;
using System.Collections.Generic;

namespace Subtask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите построчно слова для дальнейшей сортировки");
            List<string> setOfWords = new List<string>();
            bool isInputEnded = false;
            while (!isInputEnded)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLower() != "exit")
                {
                    setOfWords.Add(userInput);
                }
                else
                {
                    isInputEnded = true;
                }
            }
            bool endOfInput = false;
            while (!endOfInput)
            {
                Console.WriteLine("Введите asc или desc для выбора сортировки");
                string sortSelection = Console.ReadLine().ToLower();
                switch (sortSelection)
                {
                    case "asc":
                        setOfWords.Sort();
                        foreach (var word in setOfWords)
                        {
                            Console.WriteLine(word);
                        }
                        break;
                    case "desc":
                        setOfWords.Sort((str1, str2) => { return string.Compare(str2, str1); });
                        foreach (var word in setOfWords)
                        {
                            Console.WriteLine(word);
                        }
                        break;
                    case "exit":
                        endOfInput = true;
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неверный способ сортировки, попробуйте ещё раз");
                        break;
                }
            }
        }
    }
}
