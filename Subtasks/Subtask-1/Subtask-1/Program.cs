using System;

namespace Subtask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк");
            int N;
            while (true)
            {
                try
                {
                    N = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка, введите число");
                }
            }
            string[] cosmo = new string[N];
            Console.WriteLine("Введите строки количество которых указали ранее");
            for (int i = 0; i < N; i++)
            {
                cosmo[i] = Console.ReadLine();
            }
            Console.WriteLine("Все строки введены, выберите строку для отображения");
            string s = Console.ReadLine();
            while (s != "X")
            {
                int a;
                try
                {
                    a = Convert.ToInt32(s);
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели неверный номер элемента массива");
                    s = Console.ReadLine();
                    continue;
                }
                try
                {
                    Console.WriteLine(cosmo[a]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! Не найден индекс массива");
                }
                s = Console.ReadLine();
            }
            Console.WriteLine("Программа завершается");
        }
    }
}
