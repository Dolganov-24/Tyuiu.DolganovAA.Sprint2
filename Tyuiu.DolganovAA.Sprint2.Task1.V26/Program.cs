using Tyuiu.DolganovAA.Sprint2.Task1.V26.Lib;
namespace Tyuiu.DolganovAA.Sprint2.Task1.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            bool[] res;
            Console.Title = "Спринт 1 | Выполнил: Долганов А.А. | СМАРТб-24-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт №2                                                                  *");
            Console.WriteLine("* Тема : Операции Сравнения                                                  *");
            Console.WriteLine("* Задание №1                                                                 *");
            Console.WriteLine("* Вариант №26                                                                *");
            Console.WriteLine("* Выполнил : Долганов Александр Анатольевич | СМАРТб-24-1                    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                                  *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций, а также    *");
            Console.WriteLine("* арифметических выражений , которая вернет логическую последовательность    *");
            Console.WriteLine("*  при а=654 , b=671, c=874, d=137 .                                         *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
            Console.WriteLine("******************************************************************************");
           
            Console.Write("* a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("* b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("* c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("* d = ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ  :                                                               *");
            Console.WriteLine("******************************************************************************");
            { 
                res = ds.GetLogicOperations(a, b, c, d);
                }

            foreach (var item in res)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}