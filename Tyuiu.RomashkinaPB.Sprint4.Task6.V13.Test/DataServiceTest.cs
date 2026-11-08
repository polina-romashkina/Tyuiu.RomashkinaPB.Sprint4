using Tyuiu.RomashkinaPB.Sprint4.Task6.V13.Lib;

namespace Tyuiu.RomashkinaPB.Sprint4.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            var car = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            int res = ds.Calculate(car);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
