using Tyuiu.DolganovAA.Sprint2.Task4.V19.Lib;
namespace Tyuiu.DolganovAA.Sprint2.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            Assert.AreEqual(0.874, ds.Calculate(x, y));
        }
    }
}