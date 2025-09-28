using Tyuiu.PozdeevaEA.Sprint1.Task5.V7.Lib;
namespace Tyuiu.PozdeevaEA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 180;
            
            var res = ds.AngleToHoursMinutes(f);
           
            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}
