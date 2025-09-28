using Tyuiu.PozdeevaEA.Sprint1.Task3.V18.Lib;
namespace Tyuiu.PozdeevaEA.Sprint1.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 8;
            double b = 10;
            double c = 2;
            double wait = 20;
            var res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}
