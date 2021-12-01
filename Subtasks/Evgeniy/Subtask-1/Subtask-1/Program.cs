using System;

namespace Subtask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк");
            string g = Console.ReadLine();
            int N;
            while (true)
            {
                bool check = int.TryParse(g, out N);
                if (check == true && N >= 0)
                {
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка, введите число");
                    g = Console.ReadLine();
                }
            }
            string[] items = new string[N];
            Console.WriteLine("Введите строки количество которых указали ранее");
            for (int i = 0; i < N; i++)
            {
                items[i] = Console.ReadLine();
            }
            Console.WriteLine("Все строки введены, выберите строку для отображения");
            string s = Console.ReadLine();
            while (s != "X")
            {
                int a;
                bool result = int.TryParse(s, out a);
                if (result == true && a < N && a >= 0)
                {
                    Console.WriteLine(items[a]);
                }
                else if (a >= N)
                {
                    Console.WriteLine("Вы ввели неверный номер элемента массива");
                }
                else
                {
                    Console.WriteLine("Ошибка! Не найден индекс массива");
                }
                s = Console.ReadLine();
            }
            Console.WriteLine("Программа завершается");
        }
    }
}
