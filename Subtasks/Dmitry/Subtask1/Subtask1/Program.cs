using System;

namespace Subtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInputEnded = false;
            int numberOfLines = 0;
            Console.Write("Введите количество строк, которые хотите использовать: ");
            while (!isInputEnded)
            {
                string inputNumberLines = Console.ReadLine();
                if (int.TryParse(inputNumberLines, out numberOfLines) && numberOfLines>0)
                {
                    isInputEnded = true;
                }
                else
                {
                    Console.WriteLine("Ошибка! Нужно ввести целое положительное число");
                }
            }
            string[] lines = new string[numberOfLines];
                for (int i = 0; i < numberOfLines; i++)
                {
                    Console.WriteLine($"Введите строку {i + 1}");
                    string inputLineNumber = Console.ReadLine();
                    lines[i] = inputLineNumber;
                }
            //bool inputX = true;
            Console.Write("Все строки введены, выберите строку для отображения: ");
            while (isInputEnded)
            {
                string inputArrayIndex = Console.ReadLine();
                if (int.TryParse(inputArrayIndex, out int arrayIndex) && arrayIndex <= numberOfLines && arrayIndex > 0)
                {
                    Console.WriteLine(lines[arrayIndex - 1]);
                }
                else if (inputArrayIndex.ToLower() == "x")
                {
                    isInputEnded = false;
                    Console.WriteLine("Завершение работы!");
                }
                else
                {
                    Console.WriteLine("Ошибка! Такой строки не существует");
                }
            }  
        }
    }
}
