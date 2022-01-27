using System;

namespace Subtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк, которые хотите использовать");
            int numberLines;
            numberLines = Convert.ToInt32(Console.ReadLine());
           
           
                string[] lines = new string[numberLines];
            for (int i = 0; i < numberLines; i++)
            {
                Console.WriteLine("Введите строку");
                string input = Console.ReadLine();
                lines[i] = input;
                
            }
            bool x = true;
            while (x)

            {
                Console.WriteLine("Все строки введены, выберите строку для отображения");
                string arrayIndex = Console.ReadLine();
                int numberArrayIndext = 0;
                if (arrayIndex == "x")
                {
                    x = false;
                }
                else
                {
                    numberArrayIndext = Convert.ToInt32(arrayIndex);
                    Console.WriteLine(lines[numberArrayIndext]);
                }
                    
            }
                    


            
            
             

            
            
                
            
            

            







        }
    }
}
