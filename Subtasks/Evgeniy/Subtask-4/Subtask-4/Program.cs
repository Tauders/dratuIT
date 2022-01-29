using System;
using System.Collections.Generic;

namespace Subtask_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            List<string> listOfPeopleBySportsSection = new List<string>();
            while (userInput.ToLower() != "exit")
            {
                userInput = Console.ReadLine();
                if (userInput.ToLower() != "exit")
                {
                    listOfPeopleBySportsSection.Add(userInput);
                }
            }
            Console.WriteLine("Данные введены, выберите способ сортировки");
            int count = 0;
            string[] words = new string[listOfPeopleBySportsSection.Count];
            foreach (string choiceOfSectionByEachPerson in listOfPeopleBySportsSection)
            {

                words[count] = choiceOfSectionByEachPerson.Split(new char[] { ' ' });
                count++;
            }
        }
        
    }
}
