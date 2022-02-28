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
                Dictionary<int, List<string>> groups = new Dictionary<int, List<string>>();
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
                            
                            while (copyNames.Count != 0)
                            {
                                Random random = new Random();
                                
                                for (int i = 0; i < number; i++)
                                {
                                    int rndGroup = random.Next(number);
                                    if (i != number)
                                    {
                                        int group = rndGroup + 1;
                                        if (!groups.ContainsKey(group))
                                        {
                                            groups.Add(group, new List<string>());
                                        }

                                        for (int j = 0; j < 1; j++)
                                        {
                                            int rnd = random.Next(copyNames.Count);
                                            if (copyNames.Count != 0)
                                            {
                                                groups[group].Add(copyNames[rnd]);
                                                copyNames.RemoveAt(rnd);
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
                int index = 1;
                foreach (KeyValuePair<int, List<string>> group in groups)
                {
                    Console.WriteLine($"Группа {index}");
                    foreach (string name in group.Value)
                    {
                        Console.WriteLine(name);
                    }
                    index++;
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