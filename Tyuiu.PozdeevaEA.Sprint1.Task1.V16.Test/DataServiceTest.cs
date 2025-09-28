﻿using Tyuiu.PozdeevaEA.Sprint1.Task1.V16.Lib;
namespace Tyuiu.PozdeevaEA.Sprint1.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 2.0;
            double a = 1.0;
            double y = 3.0;
            
            var res = ds.Calculate(x, a, y);
            Assert.AreEqual(16, res);
        }
    }
}
