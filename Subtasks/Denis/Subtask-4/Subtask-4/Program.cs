using System;
using System.Collections.Generic;

namespace Subtask_4
{
    class Program
    {
        public enum SortingMethod
        {
            asc = 1,
            desc
        }

        public static SortingMethod ConvertInput(string method)
        {
            SortingMethod sorting = 0;
            if ((method == "asc") || (method == "1"))
            {
                sorting = SortingMethod.asc;
            }
            else if ((method == "desc") || (method == "2"))
            {
                sorting = SortingMethod.desc;
            }
            return sorting;
        }

        public static SortingMethod Undefined(SortingMethod method)
        {
            while (!isSelect)
            {
                input = Console.ReadLine();
                if ((method == SortingMethod.asc) || (method == SortingMethod.desc))
                {
                    isSelect = true;
                }
                else
                {
                    Console.WriteLine("Данной команды не существует. Повторите ввод");
                }
            }
            return method;
        }

        public static void SortKeyValueValues(SortingMethod method, KeyValuePair<string, List<string>> groups)
        {
            switch (method)
            {
                case SortingMethod.asc:
                    groups.Value.Sort();
                    break;
                case SortingMethod.desc:
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
            Console.WriteLine("Выберите метод сортировки: \n1.asc \n2.desc");
            string method = Console.ReadLine();
            SortingMethod sorting = ConvertInput(method);
            Undefined(sorting);
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