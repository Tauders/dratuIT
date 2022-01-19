using System;

namespace Subtask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int value = rnd.Next(3, 7);
            int[] convertedNumbers = new int[value];
            Console.WriteLine($"Программа сгенерировала случайное число, {value}");
            string[] numbers = new string[value];
            string s = Console.ReadLine();
            numbers = s.Split(new char[] { ' ' });
            int i = 0;
            for (i = 0; i < value; i++)
            {
                convertedNumbers[i] = Convert.ToInt32(numbers[i]);
            }
            Console.WriteLine("Числа ввведены, выберите нужное из доступных. X - выход");
            int[] choosenNumbers = new int[value];
            int k = 0;
            while (Console.ReadLine() != "X")
            {
                string j = Console.ReadLine();
                choosenNumbers[k] = convertedNumbers[Convert.ToInt32(j)];
                k++;
            }
            Console.WriteLine("Числа выбраны, введите необходимое действие");
            string actions = Console.ReadLine();
            int total = choosenNumbers[0];
            if (actions == "+")
            {
                for (i = 1; i <= k; i++)
                {
                    total += choosenNumbers[i];
                }
            }
            else if (actions == "-")
            {
                for(i = 1; i <= k; i++)
                {
                    total -= choosenNumbers[i];
                }
            }
            else if (actions == "/")
            {
                for (i = 1; i <= k; i++)
                {
                    total /= choosenNumbers[i];
                }
            }
            else if (actions == "*")
            {
                for (i = 1; i <= k; i++)
                {
                    total *= choosenNumbers[i];
                }
            }
            Console.WriteLine(total);
        }
    }
}
