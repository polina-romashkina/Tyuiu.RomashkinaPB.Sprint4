using Tyuiu.RomashkinaPB.Sprint4.Task7.V20.Lib;

namespace Tyuiu.RomashkinaPB.Sprint4.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "357951248632587";
            int res = ds.Calculate(n, m, str);
            int wait = 6144;
            Assert.AreEqual(wait, res);
        }
    }
}
