using System;
using System.Collections.Generic;

namespace Subtask_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            bool isExit = false;
            Console.WriteLine("Введите строки");
            while (isExit != true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Вы ничего не ввели");
                }
                else
                {
                    if (!string.Equals(input,"x", StringComparison.InvariantCultureIgnoreCase))
                    {
                        names.Add(input);
                    }
                    else
                    {
                        isExit = true;
                    }
                }
            }
            Console.WriteLine("Строки получены, введите количество групп");
            bool isRepite = false;
            while (isRepite == true)
            {
                string inputNumber = Console.ReadLine();
                Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
                if (int.TryParse(inputNumber, out int number))
                {
                    int numberOfName = names.Count / number;
                    while (names.Count != 0)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            if (i != (number))
                            {
                                string group = ($"Группа {i + 1}");
                                if (!groups.ContainsKey(group))
                                {
                                    groups.Add(group, new List<string>());
                                }

                                for (int j = 0; j < numberOfName; j++)
                                {
                                    if (names.Count != 0)
                                    {
                                        groups[group].Add(names[0]);
                                        names.RemoveAt(0);
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
                string inputSelect = Console.ReadLine();
                if(inputSelect != "y") 
                {
                    isRepite = false;
                }
            }
            
                Console.ReadKey();
        }
    }
}
