using Tyuiu.LavrentevVA.Sprint2.Task7.V8.Lib;
namespace Tyuiu.LavrentevVA.Sprint2.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 2;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);

        }
    }
}
