using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DolganovAA.Sprint2.Task0.V3.Lib
{
    public class DataService : ISprint2Task0V3
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return
            [
            x == y,
            x != y,
            x + 100 < y,
            y > x,
            y <= x,
            y >= x
            ];
        }
    }
}