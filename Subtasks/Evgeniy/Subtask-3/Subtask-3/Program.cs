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
            Console.WriteLine("Введите asc или desc для выбора сортировки");
            bool isValidAction = false;
            while (!isValidAction)
            {
                string sortSelection = Console.ReadLine();
                Enum.TryParse(sortSelection, true, out SortMethod convertedSortSelection);
                switch (convertedSortSelection)
                {
                    case SortMethod.Unknown:
                        Console.WriteLine("Вы выбрали неверный способ сортировки, попробуйте снова");
                        break;
                    case SortMethod.Asc:
                        setOfWords.Sort();
                        Console.WriteLine("Сортировка слов по алфавиту:");
                        isValidAction = true;
                        break;
                    case SortMethod.Desc:
                        setOfWords.Sort((str1, str2) => { return string.Compare(str2, str1); });
                        Console.WriteLine("Сортировка слов в обратном порядке алфавита:");
                        isValidAction = true;
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неверный способ сортировки, попробуйте снова");
                        break;
                }
            }
            foreach (var word in setOfWords)
            {
                Console.WriteLine(word);
            }

        }
        
    }
}
