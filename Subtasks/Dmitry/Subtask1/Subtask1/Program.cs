using System;

namespace Subtask1
{
    class Program
    {
        static void Main(string[] args)
        {
         
                Console.WriteLine("Введите количество строк, которые хотите использовать");
                string strLines = Console.ReadLine();
                int numberLines;
                if (int.TryParse(strLines, out numberLines) && numberLines > 0)
                {
                    int numberingLines = 1;
                    string[] lines = new string[numberLines];
                    for (int i = 0; i < numberLines; i++)
                    {
                        Console.WriteLine("Введите строку " + (numberingLines++));
                        string input = Console.ReadLine();
                        lines[i] = input;
                    }
                    bool x = true;
                    while (x)
                    {
                        Console.WriteLine("Все строки введены, выберите строку для отображения");
                        string arrayIndex = Console.ReadLine();
                        int numberArrayIndex;
                        if (arrayIndex == "x")
                        {
                            x = false;
                            Console.WriteLine("Завершение работы!");
                        }
                        else
                        {
                            if (int.TryParse(arrayIndex, out numberArrayIndex) && numberArrayIndex-- <= numberLines && numberArrayIndex > 0)
                            {
                                Console.WriteLine(lines[numberArrayIndex]);
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
