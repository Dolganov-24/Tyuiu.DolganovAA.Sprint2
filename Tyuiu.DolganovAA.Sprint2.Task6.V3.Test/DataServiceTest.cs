using Tyuiu.DolganovAA.Sprint2.Task6.V3.Lib;
namespace Tyuiu.DolganovAA.Sprint2.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {

        DataService ds = new DataService();

        [TestMethod]
        public void ValidDayNum()
        {
            Assert.AreEqual("???????????", ds.FindDayName(1));
            Assert.AreEqual("???????", ds.FindDayName(2));
            Assert.AreEqual("?????", ds.FindDayName(3));
            Assert.AreEqual("???????", ds.FindDayName(4));
            Assert.AreEqual("???????", ds.FindDayName(5));
            Assert.AreEqual("???????", ds.FindDayName(6));
            Assert.AreEqual("???????????", ds.FindDayName(7));
            Assert.AreEqual("???????? ????? ??? ??????", ds.FindDayName(8));

        }
    }
}