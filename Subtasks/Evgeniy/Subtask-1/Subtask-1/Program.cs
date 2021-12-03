using System;

namespace Subtask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк");
            string numberOfStringsUserInput = Console.ReadLine();
            int numberOfStrings;
            while (true)
            {
                bool check = int.TryParse(numberOfStringsUserInput, out numberOfStrings);
                if (check == true && numberOfStrings >= 0)
                {
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка, введите положительное число");
                    numberOfStringsUserInput = Console.ReadLine();
                }
            }
            string[] items = new string[numberOfStrings];
            Console.WriteLine("Введите строки количество которых указали ранее");
            for (int i = 0; i < numberOfStrings; i++)
            {
                items[i] = Console.ReadLine();
            }
            Console.WriteLine("Все строки введены, выберите строку для отображения");
            string choosenStringToShow = Console.ReadLine();
            while (choosenStringToShow != "X")
            {
                int selectedElementOfArray;
                bool result = int.TryParse(choosenStringToShow, out selectedElementOfArray);
                if (result == true && selectedElementOfArray < numberOfStrings && selectedElementOfArray >= 0)
                {
                    Console.WriteLine(items[selectedElementOfArray]);
                }
                else if (selectedElementOfArray >= numberOfStrings || selectedElementOfArray < 0)
                {
                    Console.WriteLine("Вы ввели неверный номер элемента массива");
                }
                else
                {
                    Console.WriteLine("Ошибка! Не найден индекс массива");
                }
                choosenStringToShow = Console.ReadLine();
            }
            Console.WriteLine("Программа завершается");
        }
    }
}
