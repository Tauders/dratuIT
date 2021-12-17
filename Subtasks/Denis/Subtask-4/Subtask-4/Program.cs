using System;
using System.Collections.Generic;

namespace Subtask_4
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
            bool isExit = false;
            Console.WriteLine("Введите данные в формате \"имя группа\", имя и группа  - одно слово ");
            while (!isExit)
            {
                string input = Console.ReadLine();
                string[] temp = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input == "X" || input == "x")
                {
                    isExit = true;
                }
                else
                {
                    string name = null;
                    string key = null;
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            key = temp[i];
                        }
                        else if (i % 2 == 0)
                        {
                            name = temp[i];
                        }
                    }
                    if (!groups.ContainsKey(key))
                    {
                        groups.Add(key, new List<string>());
                    }
                    groups[key].Add(name);
                }
            }

            foreach (string key in groups.Keys)
            {
                Console.WriteLine(key);
                foreach (string value in groups[key])
                {
                    Console.WriteLine(value);
                }
            }
            Console.ReadKey();
        }
    }
}