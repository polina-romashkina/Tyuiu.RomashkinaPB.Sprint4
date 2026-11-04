using Tyuiu.RomashkinaPB.Sprint4.Task2.V27.Lib;

namespace Tyuiu.RomashkinaPB.Sprint4.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] newArray = {2, 3, 4, 5, 6, 3, 7, 2, 3, 7, 3, 4, 5 };
            int res = ds.Calculate( newArray );
            int wait = 18;
            Assert.AreEqual( wait, res );
        }
    }
}
