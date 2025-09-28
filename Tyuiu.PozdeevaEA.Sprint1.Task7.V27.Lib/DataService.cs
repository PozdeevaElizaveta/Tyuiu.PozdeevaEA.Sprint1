using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PozdeevaEA.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double res = ((Math.Cos(Math.Pow(x,2))+ Math.Sin(Math.Pow(y, 2)))/(Math.Sin(y)+1))-((x*y-12)/(15+ Math.Cos(x)));
            res = Math.Round(res,3);
            return res;

        }
    }
}
