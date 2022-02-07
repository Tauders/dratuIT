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
            if(int.TryParse(inputNumber, out int number))
            {
                Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
                for (int i =0; i < number; i++)
                {
                    string group = ($"Группа {i+1}");
                }
            
            }
            else
            {
                Console.WriteLine("Вы указали не числовое значение. Повторите ввод");
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }



            Console.ReadKey();

        }
    }
}
