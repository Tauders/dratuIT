using System;
using System.Collections.Generic;

namespace Subtask_4
{

    class Program
    {
        static void Main(string[] args)
        {
            //List<string> person = new List<string>();
            //Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
            Dictionary<string, string> groups = new Dictionary<string, string>();
            int index = 0;
            bool isExit = false;
            Console.WriteLine("Введите данные в формате \"имя группа\", имя и группа  - одно слово ");
            while (!isExit)
            {
                string input = Console.ReadLine();
                string[] temp = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input == "X")
                {
                    isExit = true;
                }
                else
                {
                    //Group group = new Group();
                    //Person person = new Person();
                    string name = null;
                    string group = null;
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            //person.Name = temp[i];
                            //person.Add(temp[i]);
                            name = temp[i];

                        }
                        else
                        {
                            //group.Name = temp[i];
                            group = temp[i];
                        }
                    }
                    groups.Add(group, name);
                }
                
            }
            
            //if (groups.ContainsKey())
            //{
            //    Console.WriteLine("Ключи словаря равны");
            //    //groups.Add(groups.Keys, groups.Values); 
            //}

            Console.WriteLine(groups.Count);
            foreach (string name in groups.Values)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}