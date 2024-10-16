using Tyuiu.DolganovAA.Sprint2.Task5.V13.Lib;
namespace Tyuiu.DolganovAA.Sprint2.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Долганов А.А. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор  Switch                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Долганов А.А. | СМАРТб-24-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу которая использует оператор switch                   *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год (g):");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц (m):");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число (n):");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var nextDay = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine($"Следующий день: {nextDay.day}.{nextDay.month}.{nextDay.year}");
            Console.ReadKey();
        }
    }
}