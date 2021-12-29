using System;
using System.Collections.Generic;

namespace Subtask_4
{
    class Program
    {
        public static void Test(string method, Dictionary<string, List<string>> groups)
        {
            
            switch (method) 
            {
                case "asc":
                    foreach (KeyValuePair<string, List<string>> keyValuePair in groups)
                    {
                        keyValuePair.Value.Sort();
                        foreach (string value in keyValuePair.Value)
                        {
                            Console.WriteLine(value);
                        }
                    }
                    break;
                case "desc":
                    foreach (KeyValuePair<string, List<string>> keyValuePair in groups)
                    {
                        keyValuePair.Value.Sort();
                        keyValuePair.Value.Reverse();
                        foreach (string value in keyValuePair.Value)
                        {
                            Console.WriteLine(value);
                        }
                    }
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

            string method = Console.ReadLine();

            Test(method, groups);

            //foreach (KeyValuePair<string, List<string>> keyValuePair in groups)
            //{
            //    Console.WriteLine($"Группа {keyValuePair.Key}");
                
            //    foreach (string value in keyValuePair.Value)
            //    {
            //            Console.WriteLine(value);
            //    }
            //}


            //Console.WriteLine("Введите тип сортировки");
            //string method = Console.ReadLine();

            //Test(method, groups);


            Console.ReadKey();
        }
    }
}