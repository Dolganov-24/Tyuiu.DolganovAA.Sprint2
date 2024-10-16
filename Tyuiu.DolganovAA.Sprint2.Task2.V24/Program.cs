using Tyuiu.DolganovAA.Sprint2.Task2.V24.Lib;
namespace Tyuiu.DolganovAA.Sprint2.Task2.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Долганов А. А. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: оператор if - полная и короткая форма записи .                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Долганов Александр Анатольевич | СМАРТб-24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*              УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Написать программу , которая запрашивает целые значения с клавиатуры    *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами x  ,   y                  *");
            Console.WriteLine("*  в заштрихованной области  .                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*         ИСХОДНЫЕ ДАННЫЕ  :                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Переменная x : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Переменная y : ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*            РЕЗУЛЬТАТ:                                                   *");
            Console.WriteLine("***************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области .");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области .");
            }
        }
    }
}