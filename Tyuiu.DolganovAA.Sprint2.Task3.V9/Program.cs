using Tyuiu.DolganovAA.Sprint2.Task3.V9.Lib;
namespace Tyuiu.DolganovAA.Sprint2.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнил: Долганов А.А. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Долганов А.А. | СМАРТб-24-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу , которая вычисляет требуемое значение функции y с   *");
            Console.WriteLine("* использованием вложенных оператор if-else , где пользователь вводит     *");
            Console.WriteLine("* значение переменной x с клавиатуры. Округлить полученное значение до    *");
            Console.WriteLine("* трех знаков после запятой   .                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ   :                                                     *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите значение x : ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ   :                                                           *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(" Значение функции = " + res);

            Console.ReadKey();
        }
    }
}