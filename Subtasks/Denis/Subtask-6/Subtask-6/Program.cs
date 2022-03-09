using System;
using System.Collections.Generic;

namespace Subtask_6
{
    internal class Program
    {
        public static answerOptions ChoiceAnswer(string choiceInput)
        {
            answerOptions answerOption = answerOptions.Undefenite;
            if (choiceInput == "y")
            {
                answerOption = answerOptions.Yes;
            }
            else if (choiceInput == "n")
            {
                answerOption = answerOptions.No;
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
                            int group = 0;
                            for (int i = 1; i <= number; i++)
                            {
                                group = i;
                                groups.Add(group, new List<string>());
                            }

                            Random random = new Random();
                            List<int> numbers = new List<int>();
                            for (int i = 0; i < number; i++)
                            {
                                numbers.Add(i + 1);
                            }


                            while (copyNames.Count != 0)
                            {
                                List<int> copyNumbers = new List<int>(numbers);
                                while (copyNumbers.Count != 0)
                                {
                                    int randomIndes = random.Next(copyNumbers.Count);
                                    group = copyNumbers[randomIndes];
                                    copyNumbers.RemoveAt(randomIndes);
                                    int test = random.Next(copyNames.Count);
                                    if (copyNames.Count != 0)
                                    {
                                        groups[group].Add(copyNames[test]);
                                        copyNames.RemoveAt(test);
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
                
                foreach (KeyValuePair<int, List<string>> group in groups)
                {
                    Console.WriteLine($"Группа {group.Key}");
                    foreach (string name in group.Value)
                    {
                        Console.WriteLine(name);
                    }
                }
                Console.WriteLine("Ещё раз? y/n");
                bool isChoice = false;
                while (isChoice != true)
                {
                    string choiceInput = Console.ReadLine();
                    choice = ChoiceAnswer(choiceInput);
                    if (choice == answerOptions.Undefenite)
                    {
                        Console.WriteLine("Ошибка ввод. Повторите ввод");
                    }
                    else
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