using System;
using System.Collections.Generic;

namespace Subtask_4
{

    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<Sport, Person> sports = new Dictionary<Sport,Person>();
            Dictionary<string, string> sports = new Dictionary<string, string>();
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
                    sports.Add(group, name);
                }

                
                //sports.Add(sport, person);
            }

            Console.WriteLine(sports.Count);
            foreach (string name in sports.Values)
            {
                Console.WriteLine(name);
            }
        }
    }
}