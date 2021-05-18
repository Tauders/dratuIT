using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

// На входе:
// 1) Список с описанием трёхмерных геометрических фигур. Команда запускается с аргументом командной строки: путём до файла с описаниями фигур. Путь до файла абсолютный или относительный.
// 2) Программа запрашивает объём контейнера у пользователя и читает ввод с консоли. Объём контейнера вводится как вещественное число.
// Пример:
// Запуск программы:
// Запускаем ShapePacker.exe далее указываем путь к someinputfile.txt
// Пример входного файла (someinputfile.txt)
// Cube Шестигранник 2
// Sphere ВрекингБолл 100
// Cube КубикЛьда 3
// Pyramid ХанойскаяПирамидка 4 4 2
// Cylinder Шляпа 29 30

// Программа вычисляет объём каждой фигуры и в том же порядке, в котором фигуры были переданы на вход, пытается разместить их в контейнере.
// Если следующая фигура из списка уже не влезает в контейнер, программа должна продолжить проверять оставшиеся фигуры и пытаться добавить их в контейнер.
// Основной разделитель - пробел.
// В названиях фигур не допускаются пробелы!
// Все численные значения - вещественные.

// На выходе:
// 1) Первая строка Количество фигур, добавленных в контейнер
// 2) Следующие строки: названия фигур в том порядке, в котором они были добавлены в контейнер. По фигуре на строку.
// 3) Программа должна спросить у пользователя: выводить ли результат на экран или сохранить в файл (output.txt).
// 4) После вывода, программа завершает работу.
// Пример вывода:
// 2
// Шестигранник
// КубикЛьда


namespace ShapePacker
{
    
    class Program
    {
        static void Main(string[] args)
        {

            string absolutePath = @"C:\Users\Ratatata\source\repos\dratuIT\task-4\ShapePacker\ShapePacker\input.txt";
            string relativePath = "input.txt";

            foreach (string arg in args)
            {
                if (arg == absolutePath || arg == relativePath)
                {
                    Console.WriteLine("Вы запустили программу ShapePacker и указали файл со входными данными");

                    string[] readText = File.ReadAllLines(absolutePath);

                    foreach (string s in readText)
                    {
                        Console.WriteLine(s);
                    }

                    try
                    {
                        Console.WriteLine("Введите объем контейнера. Допускаются только вещественные числа ");
                        double containerVolume = double.Parse(Console.ReadLine());
                        
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Вы ввели недопустимый символ, попробуйте еще.");
                        Console.WriteLine("Для продолжения нажмите ENTER");
                        Console.ReadLine();
                        continue;
                    }

                    double height, radius, sideA, sideB;
                    const double PI = 3.1415926535897931;
                }
                else Console.WriteLine("Файл с исходными данными не найден");
            }
            Console.ReadKey();
        }
    }
}
    

// C:\Users\Ratatata\source\repos\dratuIT\task-4\ShapePacker\ShapePacker\ShapePacker.exe C:\Users\Ratatata\source\repos\dratuIT\task-4\ShapePacker\ShapePacker\input.txt
