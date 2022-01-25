using System;

namespace Subtask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int generatedNumber = rnd.Next(3, 7);
            Console.WriteLine($"Программа сгенерировала случайное число, {generatedNumber}");
            string userInput = Console.ReadLine();
            string[] numbers = userInput.Split(new char[] { ' ' });
            while (numbers.Length > generatedNumber)
            {
                Console.WriteLine("Вы ввели много данных, попробуйте снова");
                userInput = Console.ReadLine();
                numbers = userInput.Split(new char[] { ' ' });
            }
            int[] convertedNumbers = new int[generatedNumber];
            int counter = 0;
            while (counter < generatedNumber)
            {
                if (int.TryParse(numbers[counter], out int newNumbers))
                {
                    convertedNumbers[counter] = newNumbers;
                    counter++;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод: Введите числовые значения");
                    userInput = Console.ReadLine();
                    numbers = userInput.Split(new char[] { ' ' });
                    counter = 0;
                }
            }
            Console.WriteLine("Числа ввведены, выберите нужное из доступных. X - выход");
            int[] choosenNumbers = new int[generatedNumber];
            
            counter = 0;
            string inputNumbers = "";
            while (inputNumbers != "X")
            {
                inputNumbers = Console.ReadLine();
                if (inputNumbers != "X")
                {
                    bool isParsingSuccessful = int.TryParse(inputNumbers, out int newInputNumbers);
                    if (isParsingSuccessful && newInputNumbers < generatedNumber && newInputNumbers >= 0)
                    {
                        choosenNumbers[counter] = convertedNumbers[newInputNumbers];
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("Неверно введён индекс массива: введите существующий индекс массива");
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Выход из программы, так как вы ввели Х прежде, чем выбрали числа");
                return;
            }
            Console.WriteLine("Числа выбраны, введите необходимое действие");
            string action = Console.ReadLine();
            int total = choosenNumbers[0];
            if (action == "+")
            {
                for (int i = 1; i <= counter; i++)
                {
                    total += choosenNumbers[i];
                }
            }
            else if (action == "-")
            {
                for(int i = 1; i <= counter; i++)
                {
                    total -= choosenNumbers[i];
                }
            }
            else if (action == "/")
            {
                for (int i = 1; i <= counter; i++)
                {
                    if (choosenNumbers[i] == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                    }
                    total /= choosenNumbers[i];
                }
            }
            else if (action == "*")
            {
                for (int i = 1; i <= counter; i++)
                {
                    total *= choosenNumbers[i];
                }
            }
            Console.WriteLine(total);
        }
    }
}
