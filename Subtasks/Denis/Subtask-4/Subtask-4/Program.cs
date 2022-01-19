using System;
using System.Collections.Generic;

namespace Subtask_4
{
    class Program
    {
        public static void SortKeyValueValues(string method, KeyValuePair<string, List<string>> groups)
        {
            switch (method) 
            {
                case "asc":
                    groups.Value.Sort();
                    break;
                case "desc":
                    groups.Value.Sort();
                    groups.Value.Reverse();
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
            bool isExit = false;
            Console.WriteLine("Введите данные в формате \"имя группа\", имя и группа  - одно слово ");
            while (!isExit)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Вы ничего не ввели");
                }
                else
                {
                    if (input.ToUpper() == "X")
                    {
                        isExit = true;
                    }
                    else
                    {
                        string name = null;
                        string group = null;
                        string[] temp = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < temp.Length; i++)
                        {
                            name = temp[0];
                            if (temp.Length > 1)
                            {
                                group = temp[1];
                            }
                            
                        }
                        if (string.IsNullOrWhiteSpace(group))
                        {
                            Console.WriteLine("Вы не ввели ключ");
                        }
                        else
                        {
                            if (!groups.ContainsKey(group))
                            {
                                groups.Add(group, new List<string>());
                            }
                            groups[group].Add(name);
                        }
                    }
                }  
            }
            Console.WriteLine("Выберите метод сортировки");
            bool isSelect = false;
            while (!isSelect)
            {
                string method = Console.ReadLine();
                if ((method == "asc") || (method == "desc"))
                {
                    foreach (KeyValuePair<string, List<string>> keyValuePair in groups)
                    {
                        Console.WriteLine($"Группа {keyValuePair.Key}");
                        SortKeyValueValues(method, keyValuePair);
                        foreach (string value in keyValuePair.Value)
                        {
                            Console.WriteLine(value);
                        }
                    }
                    isSelect = true;
                }
                else
                {
                    Console.WriteLine("Такой команды не существует");
                    Console.WriteLine("Введите метод повторно");
                }
            }
            Console.ReadKey();
        }
    }
}