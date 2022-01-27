using System;

namespace Subtask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lengthUserInput = rnd.Next(3, 7);
            Console.WriteLine($"Программа сгенерировала случайное число, {lengthUserInput}");
            string[] result = ReadAndSplitUserInput();
            while (result.Length > lengthUserInput)
            {
                Console.WriteLine("Вы ввели много данных, попробуйте снова");
                result = ReadAndSplitUserInput();
            }
            int[] convertedNumbers = new int[lengthUserInput];
            int counter = 0;
            while (counter < lengthUserInput)
            {
                if (int.TryParse(result[counter], out int newNumbers))
                {
                    convertedNumbers[counter] = newNumbers;
                    counter++;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод: Введите числовые значения");
                    result = ReadAndSplitUserInput();
                    counter = 0;
                }
            }
            Console.WriteLine("Числа ввведены, выберите нужное из доступных. X - выход");
            int[] choosenNumbers = new int[lengthUserInput];
            
            counter = 0;
            string inputNumber = "";
            bool validUserInput = false;
            while (!validUserInput)
            {
                inputNumber = Console.ReadLine();
                if (inputNumber != "X")
                { 
                    if (int.TryParse(inputNumber, out int newInputNumbers) && newInputNumbers < lengthUserInput && newInputNumbers >= 0)
                    {
                        choosenNumbers[counter] = convertedNumbers[newInputNumbers];
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("Неверно введён индекс массива: введите существующий индекс массива");
                    }
                }
                else
                {
                    validUserInput = true;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Выход из программы, так как вы ввели Х прежде, чем выбрали числа");
                return;
            }
            Console.WriteLine("Числа выбраны, введите необходимое действие");
            int total = 0;
            string action = "";
            bool isValidAction = false;
            while (!isValidAction)
            {
                action = Console.ReadLine();
                switch (action)
                {
                    case "+":
                        total = Summation(choosenNumbers, counter);
                        isValidAction = true;
                        break;
                    case "-":
                        total = Subtraction(choosenNumbers, counter);
                        isValidAction = true;
                        break;
                    case "/":
                        total = Division(choosenNumbers, counter);
                        isValidAction = true;
                        break;
                    case "*":
                        total = Multiplication(choosenNumbers, counter);
                        isValidAction = true;
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверный оператор действия. Попробуйте ещё раз");
                        break;
                }
            }

           
        }
        public static int Summation(int[] choosenNumbers, int counter)
        {
            int total = choosenNumbers[0];
            for (int i = 1; i <= counter; i++)
            {
                total += choosenNumbers[i];
            }
            Console.WriteLine(total);
            return total;
        }
        public static int Subtraction(int[] choosenNumbers, int counter)
        {
            int total = choosenNumbers[0];
            for (int i = 1; i <= counter; i++)
            {
                total -= choosenNumbers[i];
            }
            Console.WriteLine(total);
            return total;
        }
        public static int Division(int[] choosenNumbers, int counter)
        {
            int total = choosenNumbers[0];
            for (int i = 1; i <= counter; i++)
            {
                if (choosenNumbers[i] == 0)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
                total /= choosenNumbers[i];
            }
            Console.WriteLine(total);
            return total;
        }
        public static int Multiplication(int[] choosenNumbers, int counter)
        {
            int total = choosenNumbers[0];
            for (int i = 1; i <= counter; i++)
            {
                total *= choosenNumbers[i];
            }
            Console.WriteLine(total);
            return total;
        }
        public static string[] ReadAndSplitUserInput()
        {
            string userInput = Console.ReadLine();
            string[] result = userInput.Split(new char[] { ' ' });
            return result;
        }
    }
}
