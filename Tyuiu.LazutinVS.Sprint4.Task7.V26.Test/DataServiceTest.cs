using Tyuiu.LazutinVS.Sprint4.Task7.V26.Lib;
namespace Tyuiu.LazutinVS.Sprint4.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "351268459614723";
            int r = 3;
            int c = 5;
            int wait = 18432;
            int res = ds.Calculate(r, c, str);
            Assert.AreEqual(wait, res);
        }
    }
}
