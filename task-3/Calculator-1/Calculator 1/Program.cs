using System;

namespace Calculator_1
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.Clear();
                double firstValue, secondValue, result;
                string action;

                try
                {
                    Console.WriteLine("Введите первое число, затем нажмите ENTER");
                    firstValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число, затем нажмите ENTER");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели не допустимый сомвол, попробуйте еще.");
                    Console.WriteLine("Для продолжения нажмите ENTER");
                    Console.ReadLine();
                    continue;
                }


                Console.WriteLine("Введите действие '+', '-', '*', '/', затем нажмите ENTER");
                action = Console.ReadLine();


                if (action == "+")
                {
                    result = firstValue + secondValue;
                    Console.WriteLine("Сумма = " + result);
                    Console.WriteLine("Для продолжения нажмите ENTER");
                }
                else if (action == "-")
                {
                    result = firstValue - secondValue;
                    Console.WriteLine("Разность = " + result);
                    Console.WriteLine("Для продолжения нажмите ENTER");
                }
                else if (action == "*")
                {
                    result = firstValue * secondValue;
                    Console.WriteLine("Произведение = " + result);
                    Console.WriteLine("Для продолжения нажмите ENTER");
                }
                else if (action == "/")
                {
                    if (secondValue == 0)
                    {
                        Console.WriteLine("На 0 делить нельзя.");
                        Console.WriteLine("Для продолжения нажмите ENTER");
                    }
                    else
                    {
                        result = firstValue / secondValue;
                        Console.WriteLine("Частное = " + result);
                        Console.WriteLine("Для продолжения нажмите ENTER");
                    }

                }
                else
                {
                    Console.WriteLine("Вы ввели недопустимое действие, попробуйте еще.");
                    Console.WriteLine("Для продолжения нажмите ENTER");
                }

                Console.ReadLine();

            }




        }
    }
}
