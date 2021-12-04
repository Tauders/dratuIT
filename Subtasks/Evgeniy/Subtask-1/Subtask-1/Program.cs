using System;

namespace Subtask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк");
            
            int numberOfStrings = 0;
            bool check = false;
            
              while (check == false)
              {
                string numberOfStringsUserInput = Console.ReadLine();
                check = int.TryParse(numberOfStringsUserInput, out numberOfStrings);
                check = check && numberOfStrings > 0;

                if (check == false)
                {
                    Console.WriteLine("Ошибка, введите положительное число");
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
                    Console.WriteLine("Ошибка! Некорректный ввод");
                }
                choosenStringToShow = Console.ReadLine();
            }
            Console.WriteLine("Программа завершается");
        }
    }
}
