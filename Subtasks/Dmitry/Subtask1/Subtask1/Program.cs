using System;

namespace Subtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input = true;
            while (input)
            {
                Console.Write("Введите количество строк, которые хотите использовать: ");
                string inputNumberLines = Console.ReadLine();
                if (inputNumberLines.ToLower() == "x")
                {
                    input = false;
                    Console.WriteLine("Завершение работы");
                }
                else
                {
                    if (int.TryParse(inputNumberLines, out int numberLines) && numberLines > 0)
                    {
                        string[] lines = new string[numberLines];
                        for (int i = 0; i < numberLines; i++)
                        {
                            Console.WriteLine($"Введите строку {i + 1}");
                            string inputLineNumber = Console.ReadLine();
                            lines[i] = inputLineNumber;
                        }
                        bool inputX = true;
                        Console.Write("Все строки введены, выберите строку для отображения: ");
                        while (inputX)
                        {
                            string inputArrayIndex = Console.ReadLine();
                            if (inputArrayIndex.ToLower() == "x")
                            {
                                Console.WriteLine("Завершение работы!");
                                return;
                            }
                            else
                            {
                                if (int.TryParse(inputArrayIndex, out int arrayIndex) && arrayIndex <= numberLines && arrayIndex > 0)
                                {
                                    Console.WriteLine(lines[arrayIndex - 1]);
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка! Такой строки не существует");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Нужно ввести целое положительное число от 1 до N");
                    }
                }
            }
        }
    }
}
