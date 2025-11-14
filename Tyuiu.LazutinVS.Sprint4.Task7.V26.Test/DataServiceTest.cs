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
            int[] numsArray = { 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2 };
            int res = ds.Calculate(numsArray);
            int Wait = 84375;
            Assert.AreEqual(Wait, res);
        }
    }
}
