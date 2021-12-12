using System;
using System.Collections.Generic;

namespace Subtask_4
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Group, Person> groups = new Dictionary<Group, Person>();
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
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Group group = new Group();
                            group.Name = temp[i];
                        }
                        else
                        {
                            Person person = new Person();
                            person.Name = temp[i];
                        }
                    }
                    
                }
            }

            Console.WriteLine(groups.Count);
            foreach (Person name in groups.Values)
            {
                Console.WriteLine(name);
            }
        }
    }
}