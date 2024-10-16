using Tyuiu.DolganovAA.Sprint2.Task2.V24.Lib;
namespace Tyuiu.DolganovAA.Sprint2.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea()
        {
            DataService ds = new DataService();
            int x = 8;
            int y = 9;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}