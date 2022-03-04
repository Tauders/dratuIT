using System;
using System.Collections.Generic;

namespace Subtask_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfPeopleBySportsSection = new List<string>();
            bool isInputEnded = false;
            while (!isInputEnded)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLower() != "exit")
                {
                    listOfPeopleBySportsSection.Add(userInput);
                }
                else
                {
                    isInputEnded = true;
                }
            }
            Console.WriteLine("Данные введены, выберите способ сортировки");
            int count = 0;
            string[] words = new string[listOfPeopleBySportsSection.Count];
            foreach (string choiceOfSectionByEachPerson in listOfPeopleBySportsSection)
            {

                words = choiceOfSectionByEachPerson.Split(new char[] { ' ' });
                count++;
            }
        }
        
    }
}
