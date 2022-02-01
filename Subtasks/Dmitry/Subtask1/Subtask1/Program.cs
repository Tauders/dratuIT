using System;

namespace Subtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк, которые хотите использовать");
            string inputNumberLines = Console.ReadLine();
            if (int.TryParse(inputNumberLines, out int numberLines) && numberLines > 0)
            {
                int numberingLines = 1;
                string[] lines = new string[numberLines];
                for (int i = 0; i < numberLines; i++)
                {
                    Console.WriteLine("Введите строку " + (numberingLines++));
                    string inputLineNumber = Console.ReadLine();
                    lines[i] = inputLineNumber;
                }
                bool shutDown = true;
                while (shutDown)
                {
                    Console.WriteLine("Все строки введены, выберите строку для отображения");
                    string inputArrayIndex = Console.ReadLine();
                    int arrayIndex;
                    if (inputArrayIndex == "x")
                    {
                        shutDown = false;
                        Console.WriteLine("Завершение работы!");
                    }
                    else
                    {
                        if (int.TryParse(inputArrayIndex, out arrayIndex) && arrayIndex <= numberLines && arrayIndex > 0)
                        {
                            arrayIndex--;
                            Console.WriteLine(lines[arrayIndex]);
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
