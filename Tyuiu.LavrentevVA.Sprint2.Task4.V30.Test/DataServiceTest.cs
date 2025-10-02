using Tyuiu.LavrentevVA.Sprint2.Task4.V30.Lib;
namespace Tyuiu.LavrentevVA.Sprint2.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 41.531;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 11115.459;
            Assert.AreEqual(wait, res);
        }
    }
}
