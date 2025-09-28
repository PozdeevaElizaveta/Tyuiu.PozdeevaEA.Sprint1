using Tyuiu.PozdeevaEA.Sprint1.Task6.V14.Lib;
namespace Tyuiu.PozdeevaEA.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Проверка";
            DataService ds = new DataService();

            bool res = ds.CheckLowerCaseRusLetters( strTest );
            Assert.IsFalse( res );

        }
    }
}
