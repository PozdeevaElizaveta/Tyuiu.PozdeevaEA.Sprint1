using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PozdeevaEA.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            double res = f / (360 / 12);
            int h = Convert.ToInt32(res);
            return h;
        }
    }
}
