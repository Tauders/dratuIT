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
                number2 = double.Parse(args[1]);
                action = char.Parse(args[2]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Введены некорректные символы, пожалуйста попробуйте ещё раз, используя подобную форму ввода: число число операция. Полученная ошибка: {ex.Message}");
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
