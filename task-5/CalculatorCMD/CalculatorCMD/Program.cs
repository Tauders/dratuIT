using System;

namespace CalculatorCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = double.Parse(args[0]);
                double b = double.Parse(args[1]);
                char oper = char.Parse(args[2]);
            
                double total;

                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine(total);
                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine(total);
                }

                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine(total);
                }

                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine(total);
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Введены некорректные символы, пожалуйста попробуйте ещё раз, используя подобную форму ввода: число число операция. Полученная ошибка: {ex.Message}");
            }
        }
    }
}
