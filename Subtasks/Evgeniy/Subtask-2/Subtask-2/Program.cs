using System;

namespace Subtask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int value = rnd.Next(3, 7);
            Console.WriteLine($"Программа сгенерировала случайное число, {value}");
            string[] chisla = new string[value];
            string s = Console.ReadLine();
            chisla = s.Split();
            int a;
            for(a = 0; a < value; a++)
            {
                a = Convert.ToInt32(chisla);
            }
            Console.WriteLine($"{a}");

            Console.WriteLine("Числа введены выберите доступные");
        }
    }
}
