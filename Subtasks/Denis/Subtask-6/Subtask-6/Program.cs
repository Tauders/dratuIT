using System;
using System.Collections.Generic;

namespace Subtask_6
{
    internal class Program
    {
        public static answerOptions ChoiceAnswer(string choiceInput)
        {
            answerOptions answerOption = answerOptions.Undefenite;
            switch (choiceInput) 
            {
                case "y":
                    answerOption = answerOptions.Yes;
                    break;
                case "n":
                    answerOption = answerOptions.No;
                    break;
                default:
                    Console.WriteLine("Ошибка ввода. Повторите ввод");
                    break;
            }
            return answerOption;
        }

        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            bool isInputTermination = false;
            Console.WriteLine("Введите строки");
            while (isInputTermination != true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Вы ничего не ввели");
                }
                else
                {
                    if (!string.Equals(input, "x", StringComparison.InvariantCultureIgnoreCase))
                    {
                        names.Add(input);
                    }
                    else
                    {
                        isInputTermination = true;
                    }
                }
            }

            answerOptions choice = answerOptions.Undefenite;
            while (choice != answerOptions.No)
            {
                List<string> copyNames = new List<string>(names);
                Console.WriteLine("Строки получены, введите количество групп");
                Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
                bool isDigit = false;
                while (isDigit != true)
                {
                    string inputNumber = Console.ReadLine();
                    if (int.TryParse(inputNumber, out int number))
                    {

                        if (number > copyNames.Count)
                        {
                            Console.WriteLine("Вы указали некорректное число. Повторите ввод");
                        }

                        else
                        {
                            int numberOfName = copyNames.Count / number;
                            while (copyNames.Count != 0)
                            {
                                for (int i = 0; i < number; i++)
                                {
                                    if (i != number)
                                    {
                                        string group = ($"Группа {i + 1}");
                                        if (!groups.ContainsKey(group))
                                        {
                                            groups.Add(group, new List<string>());
                                        }

                                        for (int j = 0; j < numberOfName; j++)
                                        {
                                            if (copyNames.Count != 0)
                                            {
                                                groups[group].Add(copyNames[0]);
                                                copyNames.RemoveAt(0);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        i = 0;
                                    }
                                }
                            }
                            isDigit = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввод. Повторите ввод");
                    }
                }

                foreach (KeyValuePair<string, List<string>> group in groups)
                {
                    Console.WriteLine(group.Key);
                    foreach (string name in group.Value)
                    {
                        Console.WriteLine(name);
                    }
                }
                Console.WriteLine("Ещё раз? y/n");
                bool isChoice = false;
                while(isChoice != true)
                {
                    string choiceInput = Console.ReadLine();
                    choice = ChoiceAnswer(choiceInput);
                    if (choice != answerOptions.Undefenite)
                    {
                        isChoice = true;
                    }
                }
            }
            Console.WriteLine("Завершение программы");
            Console.ReadKey();
        }
    }
}