using Tyuiu.DolganovAA.Sprint2.Task0.V3.Lib;
namespace Tyuiu.DolganovAA.Sprint2.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 1 | Выполнил: Долганов А.А. | СМАРТб-24-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт №2                                                                  *");
            Console.WriteLine("* Тема : Операции Сравнения                                                  *");
            Console.WriteLine("* Задание №0                                                                 *");
            Console.WriteLine("* Вариант №3                                                                 *");
            Console.WriteLine("* Выполнил : Долганов Александр Анатольевич | СМАРТб-24-1                    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                                  *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений        *");
            Console.WriteLine("* которая вернёт логическую последовательность, при х =45 , у =127           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*          x    =    45       ,       y    =    127                          *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ  :                                                               *");
            Console.WriteLine("******************************************************************************");

            int x = 45;
            int y = 127;

            bool[] ress = ds.GetCompareOperations(x, y);
            Console.WriteLine("Результаты операций сравнения :");
            foreach (var res in ress)
            {
                Console.WriteLine(res);
            }



            Console.ReadKey();
        }
    }
}