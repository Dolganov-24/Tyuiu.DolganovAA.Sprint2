using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DolganovAA.Sprint2.Task2.V24.Lib
{
    public class DataService : ISprint2Task2V24
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3 && x <= 5 && y >= 3 && y <= 7) | (x >= 6 && x <= 8 && y >= 5 && y <= 10) | (x >= 9 && x <= 12 && y >= 3 && y <= 6) | (x >= 9 && x <= 12 && y >= 9 && y <= 10) | (x >= 3 && x <= 7 && y == 11) | (x >= 11 && x <= 12 && y >= 11 && y <= 12) | (x == 7 && y == 12) | (x == 13 && y == 6))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}