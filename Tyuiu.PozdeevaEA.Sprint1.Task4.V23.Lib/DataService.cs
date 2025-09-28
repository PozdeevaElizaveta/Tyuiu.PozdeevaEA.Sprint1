using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PozdeevaEA.Sprint1.Task4.V23.Lib
{
    public class DataService : ISprint1Task4V23
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round((Math.Sqrt(Math.Abs(x+y))) / (Math.Abs(3 - x)), 3);
            return res;
        }
    }
}
