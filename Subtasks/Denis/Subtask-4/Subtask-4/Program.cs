using System;
using System.Collections.Generic;

namespace Subtask_4
{
    class Program
    {
        public enum SortingMethod
        {
            asc = 1,
            desc,
            exit,
            undefined
        }

        public static SortingMethod ConvertInput(string method)
        {
            SortingMethod sorting = 0;
            if ((method == "asc") || (method == "1"))
            {
                sorting = SortingMethod.asc;
                Console.WriteLine("По возрастанию");
            }
            else if ((method == "desc") || (method == "2"))
            {
                sorting = SortingMethod.desc;
                Console.WriteLine("По убыванию");
            }
            else if ((method == "exit") || (method == "3"))
            {
                sorting = SortingMethod.exit;
                Console.WriteLine("Не сортированный список");
            }
            else
            {
                sorting = SortingMethod.undefined;
                Console.WriteLine("Указанный вами метод не существует. Поворите ввод");
            }
            return sorting;
        }

        public static void PrintResult(Dictionary<string, List<string>> groups, SortingMethod sorting)
        {
            foreach (KeyValuePair<string, List<string>> group in groups)
            {
                Console.WriteLine($"Группа {group.Key}");
                SortKeyValueValues(sorting, group);
                foreach (string value in group.Value)
                {
                    Console.WriteLine(value);
                }
            }
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
                case SortingMethod.exit:
                    
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
            Console.WriteLine("Выберите метод сортировки: \n1. asc (сортировка по возрастанию) \n2. desc (сортировка по убыванию) \n3. exit (вывести исходный словарь)");
            bool isUndefined = false;
            SortingMethod sorting = 0;
            while (!isUndefined)
            {
                string method = Console.ReadLine();
                sorting = ConvertInput(method);
                if (sorting != SortingMethod.undefined)
                {
                    isUndefined = true;
                }
            }
            PrintResult(groups, sorting);
            Console.ReadKey();
        }
    }
}