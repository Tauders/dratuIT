using System;
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
                    break;
                case SortingMethod.Desc:
                    groups.Value.Sort();
                    groups.Value.Reverse();
                    break;
                default:
                    Console.WriteLine("Данного метода не существует. Повторите ввод");
                    break;
            }
        }

        public static SortingMethod test(string input) 
        {
            SortingMethod sorting = SortingMethod.Undefined;
            if (int.TryParse(input, out _))
            {
                Enum.TryParse<SortingMethod>(input, true, out sorting);
                if (!Enum.IsDefined(typeof(SortingMethod), sorting))
                {
                    sorting = SortingMethod.Undefined;
                }
            }
            else
            {
                Enum.TryParse<SortingMethod>(input, true, out sorting);
                if (!Enum.IsDefined(typeof(SortingMethod), sorting))
                {
                    sorting = SortingMethod.Undefined;
                }
            }
            return sorting;
        }
       
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
            bool isInputTermination = false;
            Console.WriteLine("Введите данные в формате \"имя группа\", имя и группа  - одно слово ");
            while (!isInputTermination)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Вы ничего не ввели");
                }
                else
                {
                    if (string.Equals(input, "x", StringComparison.InvariantCultureIgnoreCase))
                    {
                        isInputTermination = true;
                    }
                    else
                    {
                        string[] temp = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        string name = null;
                        string group = null;
                        if (temp.Length == 2)
                        {
                            name = temp[0];
                            group = temp[1];
                        }

                        if ((temp.Length <= 1) || (temp.Length > 2))
                        {
                            Console.WriteLine("Допушена ошибка при вводе");
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
            Console.WriteLine("Выберите метод сортировки:");
            Console.WriteLine("1. Asc");
            Console.WriteLine("2. Desc");
            SortingMethod sorting = SortingMethod.Undefined;
            while (sorting == SortingMethod.Undefined)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) 
                {
                    Console.WriteLine("Вы ничего не ввели");
                }
                else
                {
                   sorting = test(input);
                }
                Console.WriteLine($"{input} = {sorting}");
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