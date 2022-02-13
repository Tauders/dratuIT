using System;
using System.Collections.Generic;

namespace Subtask_6
{
    internal class Program
    {
        public static answerOptions ChoiceAnswer(answerOptions choice)
        {
            switch (choice)
            {
                case answerOptions.Yes:
                    choice = answerOptions.Yes;
                    break;
                case answerOptions.No:
                    choice = answerOptions.No;
                    break;
            }
            return choice;
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
                string inputNumber = Console.ReadLine();
                Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
                if (int.TryParse(inputNumber, out int number))
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
                }
                else
                {
                    Console.WriteLine("Вы указали не числовое значение. Повторите ввод");
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
                string choiceInput = Console.ReadLine();
                if (Enum.TryParse<answerOptions>(choiceInput, true, out choice))
                {
                    if(Enum.IsDefined(typeof(answerOptions), choice))
                    {
                        ChoiceAnswer(choice);
                    }
                    else
                    {
                        Console.WriteLine("Данного варианта ответа нету. Повторите ввод");
                    }
                    
                }                
            }
            Console.WriteLine("Завершение программы");
            Console.ReadKey();
        }
    }
}