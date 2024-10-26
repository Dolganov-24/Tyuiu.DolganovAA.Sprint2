using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DolganovAA.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 4) && ((x > 0) && (x <= 2) && ((y > 0) && (x <= 2))))
            {
                if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && ((x > 0) && (x <= 1) && ((y > 0) && (x <= 1)))) return false;
                else return true;
            }
            else return false;
        }
    }
}