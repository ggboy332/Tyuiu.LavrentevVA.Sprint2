using Tyuiu.LavrentevVA.Sprint2.Task3.V11.Lib;
namespace Tyuiu.LavrentevVA.Sprint2.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 10;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void TestMethod2()
        {

        }
        [TestMethod]
        public void TestMethod3()
        {

        }
        [TestMethod]
        public void TestMethod4()
        {

        }
    }
}
