using Tyuiu.RomashkinaPB.Sprint4.Task5.V20.Lib;

namespace Tyuiu.RomashkinaPB.Sprint4.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -7, -3, -4, -2, -1 }, { 1, 2, 3, 2, 1 }, { -7, -5, -3, 2, 3 }, { 1, 2, 3, 0, -1 }, 
                { -2, -3, 1, 2, -6 } };

            int res = ds.Calculate(mas2);
            int wait = 23;

            Assert.AreEqual(wait, res);
        }
    }
}
