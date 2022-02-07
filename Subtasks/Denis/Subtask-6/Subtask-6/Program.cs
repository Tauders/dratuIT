using System;
using System.Collections.Generic;

namespace Subtask_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            bool isSelect = false;
            Console.WriteLine("Введите строки");
            while (isSelect != true)
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
                        isSelect = true;
                    }
                }
            }
            Console.WriteLine("Строки получены, введите количество групп");
            string inputNumber = Console.ReadLine();
            int numberOfName = 0;
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
            if (int.TryParse(inputNumber, out int number))
            {
                if(names.Count / 2 == 0)
                {
                    numberOfName = names.Count / number;
                }
                else if (names.Count / 2 != 0)
                {
                    numberOfName = names.Count % number;
                }
                
                for (int i = 0, j = 0; i < number; i++)
                {
                    string group = ($"Группа {i+1}");
                    groups.Add(group, new List<string>());
                    for(; j < names.Count/number; j++)
                    {
                        groups[group].Add(names[j]);
                    }
                    j += 2;
                    
                }
                Console.WriteLine(names.Count);
                Console.WriteLine(numberOfName);
            
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
            



            Console.ReadKey();

        }
    }
}
