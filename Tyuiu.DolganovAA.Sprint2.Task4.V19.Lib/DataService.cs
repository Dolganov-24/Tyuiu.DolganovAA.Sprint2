using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DolganovAA.Sprint2.Task4.V19.Lib
{
    public class DataService : ISprint2Task4V19
    {
        public double Calculate(double x, double y)
        {
            double res = ((x + 2) < (y - 6)) ? Math.Round((Math.Pow((6 + (4 / Math.Pow(y, 2))), x)), 3) : Math.Round(((Math.Pow(x, 2) - Math.Cos(Math.Pow(y, 2)) + 10) / (Math.Pow(y, 2) - Math.Sin(Math.Pow(y, 2)) + 12)), 3);
            return res;
        }
    }
}