using System;

namespace CalculatorCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            char action;
            try
            {
                number1 = double.Parse(args[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Вы ввели первый аргумент неправильно. Полученная ошибка: {ex.Message}");
                return;
            }
            try
            {
                number2 = double.Parse(args[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Вы ввели второй аргумент неправильно. Полученная ошибка: {ex.Message}");
                return;
            }
            try
            {
                action = char.Parse(args[2]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Вы неверно ввели третий аргумент. Полученная ошибка: {ex.Message}");
                return;
            }
            double total;

                if (action == '+')
                {
                    total = number1 + number2;
                    Console.WriteLine(total);
                }
                else if (action == '-')
                {
                    total = number1 - number2;
                    Console.WriteLine(total);
                }
                else if (action == '*')
                {
                    total = number1 * number2;
                    Console.WriteLine(total);
                }
                else if (action == '/')
                {
                    if (number2 == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                        return;
                    }
                    total = number1 / number2;
                    Console.WriteLine(total);
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор");
                }
        }
    }
}
