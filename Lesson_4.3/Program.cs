using System;
using static System.Console;

namespace Lesson_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random RandomNum = new Random();

            WriteLine("Введите максимальное значение диапазона");
            int Max = int.Parse(ReadLine());

            int RandomValue = RandomNum.Next(0, Max + 1);

            while (true)
            {
                WriteLine("Угадайте часло или нажмите Enter для выхода");
                string Pick = ReadLine();
                if (Pick == "")
                {
                    return;
                }
                else if (int.Parse(Pick) < RandomValue)
                {
                    WriteLine("Это число меньше угадываемого");
                }
                else if (int.Parse(Pick) > RandomValue)
                {
                    WriteLine("Это число больше угадываемого");
                }
                else
                {
                    WriteLine($"{RandomValue} - правильное число");
                    break;
                }
            }
            ReadKey();
        }
    }
}
