using System;
using System.Collections.Generic;

namespace Subtask_4
{

    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<Group, Person> sports = new Dictionary<Group, Person>();
            Dictionary<string, string> groups = new Dictionary<string, string>();
            bool isExit = false;
            Console.WriteLine("Введите данные в формате \"имя группа\", имя и группа  - одно слово ");
            while (!isExit)
            {
                string input = Console.ReadLine();
                string[] temp = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                //Sport sport = new Sport();
                //Person person = new Person();


                if (input == "X")
                {
                    isExit = true;
                }
                else
                {
                    string name;
                    string group;
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            name = temp[i];
                        }
                        else
                        {
                            group = temp[i];
                        }
                    }
                    groups.Add(group, name);
                }


                //sports.Add(sport, person);
            }

            Console.WriteLine(groups.Count);
            foreach (string name in groups.Values)
            {
                Console.WriteLine(name);
            }
        }
    }
}