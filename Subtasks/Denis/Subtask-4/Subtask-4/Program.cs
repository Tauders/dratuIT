﻿using System;
using System.Collections.Generic;



namespace Subtask_4
{
    class Program
    {
        public static void SortKeyValueValues(SortingMethod method, KeyValuePair<string, List<string>> groups)
        {
            switch (method)
            {
                case SortingMethod.Asc:
                    groups.Value.Sort();
                    Console.WriteLine("По возрастанию");
                    break;
                case SortingMethod.Desc:
                    groups.Value.Sort();
                    groups.Value.Reverse();
                    Console.WriteLine("По убыванию");
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
            Console.WriteLine("Выберите метод сортировки: \n1. Asc \n2. Desc");
            SortingMethod sorting = SortingMethod.Undefined;
            bool isUndefined = true;
            while (isUndefined)
            {
                string method = Console.ReadLine();
                if (Enum.TryParse(method, true, out sorting))
                {
                    if(Enum.IsDefined(typeof(SortingMethod), sorting))
                    {
                        isUndefined = false;
                    }
                }
                else
                {
                    sorting = SortingMethod.Undefined;
                    Console.WriteLine("Данного метода не существует. Повторите ввод");
                }
            }

            foreach (KeyValuePair<string, List<string>> group in groups)
            {
                Console.WriteLine($"Группа {group.Key}");
                SortKeyValueValues(sorting, group);
                foreach (string value in group.Value)
                {
                    Console.WriteLine(value);
                }
            }
            Console.ReadKey();
        
        }
    }
}