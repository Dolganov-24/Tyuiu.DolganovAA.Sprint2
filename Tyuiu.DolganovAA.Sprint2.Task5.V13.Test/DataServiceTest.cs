using Tyuiu.DolganovAA.Sprint2.Task5.V13.Lib;
namespace Tyuiu.DolganovAA.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetNextDay()
        {

            DataService ds = new DataService();

            var res = ds.FindDateOfNextDay(2020, 2, 28);
            Assert.AreEqual((2020, 2, 29), res);

            res = ds.FindDateOfNextDay(2020, 2, 29);
            Assert.AreEqual((2020, 3, 1), res);

            res = ds.FindDateOfNextDay(2020, 12, 31);
            Assert.AreEqual((2021, 1, 1), res);

            res = ds.FindDateOfNextDay(2020, 4, 30);
            Assert.AreEqual((2020, 5, 1), res);
        }
    }
}