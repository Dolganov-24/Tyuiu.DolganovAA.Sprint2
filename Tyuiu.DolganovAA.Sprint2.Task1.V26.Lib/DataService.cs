using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DolganovAA.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return [a == b | a == a, b == b & c == c, a == a || a == b, a == b && a == a, !(a == b), a == b ^ a == b];
        }
    }
}