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
            while (i != (value - 1))
            {
                bool firstSuccess = int.TryParse(numbers[i], out int newNumbers);
                if (firstSuccess)
                {
                    convertedNumbers[i] = newNumbers;
                    i++;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод: Введите числовые значения");
                    s = Console.ReadLine();
                    numbers = s.Split(new char[] { ' ' });
                    i = 0;
                }
            }
            Console.WriteLine("Числа ввведены, выберите нужное из доступных. X - выход");
            int[] choosenNumbers = new int[value];
            
            int counter = 0;
            string inputNumbers = "";
            while (inputNumbers != "X")
            {
                inputNumbers = Console.ReadLine();
                    if (inputNumbers != "X")
                    {
                         bool secondSuccess = int.TryParse(inputNumbers, out int newInputNumbers);
                         if (secondSuccess && newInputNumbers < value && newInputNumbers >= 0)
                         {
                              choosenNumbers[counter] = convertedNumbers[newInputNumbers];
                              counter++;
                         }
                         else
                         {
                             Console.WriteLine("Неверно введён индекс массива: введите существующий индекс массива");
                         }
                    }
            }
            Console.WriteLine("Числа выбраны, введите необходимое действие");
            string actions = Console.ReadLine();
            int total = choosenNumbers[0];
            if (actions == "+")
            {
                for (i = 1; i <= counter; i++)
                {
                    total += choosenNumbers[i];
                }
            }
            else if (actions == "-")
            {
                for(i = 1; i <= counter; i++)
                {
                    total -= choosenNumbers[i];
                }
            }
            else if (actions == "/")
            {
                for (i = 1; i <= counter; i++)
                {
                    if (choosenNumbers[i] == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                    }
                    total /= choosenNumbers[i];
                }
            }
            else if (actions == "*")
            {
                for (i = 1; i <= counter; i++)
                {
                    total *= choosenNumbers[i];
                }
            }
            Console.WriteLine(total);
        }
    }
}
