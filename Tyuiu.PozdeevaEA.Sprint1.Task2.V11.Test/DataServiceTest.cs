using Tyuiu.PozdeevaEA.Sprint1.Task2.V11.Lib;
namespace Tyuiu.PozdeevaEA.Sprint1.Task2.V11.Test
{

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 3;
            int valueTwo = 10;

            var res = ds.ConvertHoursMinutesToSeconds(value, valueTwo);

            Assert.AreEqual(11400, res);
        }

    }
}

