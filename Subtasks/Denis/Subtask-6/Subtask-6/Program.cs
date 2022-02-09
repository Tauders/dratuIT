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
            string inputNumber = Console.ReadLine();
            
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
            if (int.TryParse(inputNumber, out int number))
            {
                int numberOfName = names.Count / number;

                //if (names.Count / 2 != 0)
                //{
                //    //numberOfName = names.Count % number;
                //    Console.WriteLine("нечетное число");
                //}

                //if (names.Count / 2 == 0)
                //{
                    
                //}
                for (int i = 0; i < number; i++)
                {
                    string group = ($"Группа {i + 1}");
                    groups.Add(group, new List<string>());
                    for (int j = 0; j < numberOfName; j++)
                    {
                        groups[group].Add(names[0]);
                        names.RemoveAt(0);
                    }
                }

                //Console.WriteLine(names.Count);
                //Console.WriteLine(numberOfName);

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
