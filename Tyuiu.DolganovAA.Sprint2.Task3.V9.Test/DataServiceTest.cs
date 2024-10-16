using Tyuiu.DolganovAA.Sprint2.Task3.V9.Lib;
namespace Tyuiu.DolganovAA.Sprint2.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 23.12;
            Assert.AreEqual(wait, res);

        }


        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -0.372;
            Assert.AreEqual(wait, res);
        }


        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);

        }


        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -17.5;
            Assert.AreEqual(wait, res);
        }
    }
}